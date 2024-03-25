using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Clients
{
    public class CreateClient : IRequest<OperationResult<Client>>
    {
        public string ClientName { get; private set; }
        public string ClientId { get; private set; }
        public string ClientSecret { get; private set; }
        public string Description { get; private set; }
        public int AccessTokenLifeTime { get; private set; }
        public int RefreshTokenLifeTime { get; private set; }
        public List<long> ApiClaims { get; private set; } = new List<long>();
    }
    internal class CreateClinetHandler : IRequestHandler<CreateClient, OperationResult<Client>>
    {
        private readonly IRepositoryBase<Client> _client;
        private readonly IPassword _passwordService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateClinetHandler(IRepositoryBase<Client> client, IMapper mapper, IPassword passwordService, IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _passwordService = passwordService;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Client>> Handle(CreateClient request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<Client>();
            try
            {
                if (await _client.ExistWhereAsync(c => c.ClientId == request.ClientId && c.RecordStatus != RecordStatus.Deleted))
                {
                    result.AddError(ErrorCode.RecordExist, "Client ID is registerd.");
                    return result;
                }
                var client = Client.CreatClient(request.ClientName, request.ClientId, request.ClientSecret, request.Description, request.AccessTokenLifeTime, request.RefreshTokenLifeTime);
                client.UpdateSecret(await _passwordService.HashPassword(request.ClientSecret));
                request.ApiClaims.ForEach(claimId =>
                {
                    client.AddApiResource(ClientApiResources.Create(client.Id, claimId));
                });
                client.Register(_session.GetString("user"));


                await _client.AddAsync(client);

                result.Payload = client;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;

        }
    }
}

