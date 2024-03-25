using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Clients
{
    public class GetAllClient : IRequest<OperationResult<IEnumerable<Client>>>
    {
        public RecordStatus? recordStatus { get; set; }
    }
    internal class GetAllClientQueryHandler : IRequestHandler<GetAllClient, OperationResult<IEnumerable<Client>>>
    {
        private readonly IRepositoryBase<Client> _client;
        public GetAllClientQueryHandler(IRepositoryBase<Client> client)
        {
            _client = client;
        }

        public async Task<OperationResult<IEnumerable<Client>>> Handle(GetAllClient request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<Client>>();
            try
            {

                var client = request.recordStatus switch
                {
                    RecordStatus.Active => _client.Where(x => x.RecordStatus == RecordStatus.Active, "ClientApiResources", "ClientApiResources.ApiClaim").ToList(),
                    RecordStatus.InActive => _client.Where(x => x.RecordStatus == RecordStatus.InActive, "ClientApiResources", "ClientApiResources.ApiClaim").ToList(),
                    _ => _client.Where(x => x.RecordStatus != RecordStatus.Deleted, "ClientApiResources", "ClientApiResources.ApiClaim").ToList(),
                };

                if (client is null || client.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "Client is not found!");
                    return result;
                }
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
