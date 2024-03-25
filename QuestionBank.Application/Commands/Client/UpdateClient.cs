using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;

namespace QuestionBank.Application.Commands.Clients
{
    public class UpdateClient : IRequest<OperationResult<Client>>
    {
        public long Id { get; set; }
        public string ClientName { get; private set; }
        public string ClientId { get; private set; }
        public string Description { get; private set; }
        public int AccessTokenLifeTime { get; private set; }
        public int RefreshTokenLifeTime { get; private set; }
        public List<long> ApiClaims { get; private set; } = new List<long>();
    }
    internal class UpdateClientHandler : IRequestHandler<UpdateClient, OperationResult<Client>>
    {
        private readonly IRepositoryBase<Client> _client;
        private readonly IPassword _passwordService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateClientHandler(IRepositoryBase<Client> client, IPassword passwordService, IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _passwordService = passwordService;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Client>> Handle(UpdateClient request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Client>();

            try
            {
                var client = await _client.FindAsync(request.Id);

                if (client is null)
                {
                    result.AddError(ErrorCode.NotFound, "Client Not found!");
                    return result;
                }

                client.UpdateClient(request.ClientName, request.ClientId, request.Description, request.AccessTokenLifeTime, request.RefreshTokenLifeTime);

               if (request.ApiClaims.Count > 0)
                {
                    var CurrentApiClaims = _client.Where(i => i.Id == client.Id, "ClientApiResources").Select(x => x.ClientApiResources).ToList();
                   
                    foreach(var claim in CurrentApiClaims[0])
                    {
                        client.RemoveApiResource(claim);
                    }
                    request.ApiClaims.ForEach(claimId =>
                    {   
                        client.AddApiResource(ClientApiResources.Create(client.Id, claimId));
                    });
                }
                client.UpdateAudit(_session.GetString("user"));
                _client.Update(client);
                result.Payload = client;
                return result;
            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}