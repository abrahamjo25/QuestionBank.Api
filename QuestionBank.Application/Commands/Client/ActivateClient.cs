using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Clients
{
    public class ActivateClient : IRequest<OperationResult<Client>>
    {
        public string ClientId { get; set; }
        public RecordStatus Status { get; set; }
    }

    internal class ActivateClientHandler : IRequestHandler<ActivateClient, OperationResult<Client>>
    {
        private readonly IRepositoryBase<Client> _client;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public ActivateClientHandler(IRepositoryBase<Client> client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<OperationResult<Client>> Handle(ActivateClient request, CancellationToken cancellationToken)
        {
           var result = new OperationResult<Client>();
            try
            {
                var client = await _client.FirstOrDefaultAsync(c => c.ClientId == request.ClientId && c.RecordStatus != RecordStatus.Deleted);
                if (client is null)
                {
                    result.AddError(ErrorCode.NotFound, "Client not found!");
                    return result;
                }

                client.UpdateStatus(request.Status);
                client.UpdateAudit(_session.GetString("user"));

                _client.Update(client);

                result.Payload = client;
                result.Message = "Operation Success";

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
