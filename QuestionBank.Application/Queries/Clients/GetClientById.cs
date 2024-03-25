using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
namespace QuestionBank.Application.Queries.Clients
{
    public class GetClientById : IRequest<OperationResult<Client>>
    {
        public long Id { get; set; }
    }
    internal class GetClienByIdtQueryHandler : IRequestHandler<GetClientById, OperationResult<Client>>
    {
        private readonly IRepositoryBase<Client> _client;
        public GetClienByIdtQueryHandler(IRepositoryBase<Client> client)
        {
            _client = client;
        }
        public async Task<OperationResult<Client>> Handle(GetClientById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Client>();
            try
            {
                var client = await _client.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus == RecordStatus.Active, "ClientApiResources", "ClientApiResources.ApiClaim");

                if (client is null)
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
