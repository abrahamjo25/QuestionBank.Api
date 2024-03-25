using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using MediatR;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Application.Helpers.Dtos;
using QuestionBank.Domain.Models;
using QuestionBank.Infrastructure.Context;

namespace QuestionBank.Application.Commands.Clients
{
    public class LoginClient: IRequest<OperationResult<ClientLoginDto>>
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
    internal class LoginClientHandler : IRequestHandler<LoginClient, OperationResult<ClientLoginDto>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IPassword _passwordService;
        private readonly ITokenhandler _tokenService;
        public LoginClientHandler(ApplicationDbContext context, IPassword passwordService, ITokenhandler tokenService)
        {
            _context = context;
            _tokenService = tokenService;
            _passwordService = passwordService;
        }
        public async Task<OperationResult<ClientLoginDto>> Handle(LoginClient request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<ClientLoginDto>();
            var clientresponse = new ClientLoginDto();
            var client = await _context.Client
                .Where(x => x.ClientId == request.ClientId)
                .Include(x => x.ClientApiResources)
                    .ThenInclude(x => x.ApiClaim)
                .FirstOrDefaultAsync();
            if (client is null)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "Client user doesn't exist.");
                return result;
            }
            if (! await _passwordService.ValidatePassword(client.ClientSecret, request.ClientSecret))
            {
                result.AddError(ErrorCode.IncorrectPassword, "Invalide password.");
                return result;
            }
            clientresponse.ClientId = client.ClientId;
            clientresponse.AccessToken = await GetJwtString(client, _getClaim(client));
            clientresponse.RefreshToken = await _setRefreshToken(client);
            result.Payload = clientresponse;
            return result;
        }
        private List<Claim> _getClaim(Client client)
        {
            var result = new List<Claim>();
            result.Add(new Claim("clientId", client.ClientId));
            foreach (var clientClaim in client.ClientApiResources)
            {
                Claim claim = new Claim(clientClaim.ApiClaim.Id.ToString(), String.Format("{0}#{1}#{2}", clientClaim.ApiClaim.ServiceId, clientClaim.ApiClaim.Claim, clientClaim.ApiClaim.RequireIdToken));
                result.Add(claim);
            }
            return result;
        }
        private async Task<string> GetJwtString(Client client, List<Claim> claimList)
        {
            var claims = new[]
                {
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
             }
                .Union(claimList).ToList();
            var token =await _tokenService.CreateSecurityToken(claims, client.AccessTokenLifeTime);
            return await _tokenService.WriteToken(token);
        }
        private async Task<string> _setRefreshToken(Client client)
        {
            client.RefreshTokenExpireDate = DateTime.UtcNow.AddMinutes(client.RefreshTokenLifeTime);
            client.RefreshToken =await  _tokenService.GenerateRefreshToken();
            _context.Client.Update(client);
            _context.SaveChanges();
            return client.RefreshToken;
        }
    }
}