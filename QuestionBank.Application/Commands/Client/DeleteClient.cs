using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Clients
{
    public class DeleteClient: IRequest<OperationResult<bool>>
    {
        public long Id { get; set; }
    }
    internal class DeleteClientHandler : IRequestHandler<DeleteClient, OperationResult<bool>>
    {
        private readonly IRepositoryBase<Client> _client;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public DeleteClientHandler(IRepositoryBase<Client> client , IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<bool>> Handle(DeleteClient request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<bool>();
            try
            {
                var client =  _client.Find(request.Id);
                if (client is null)
                {
                    result.AddError(ErrorCode.NotFound, "Client not found");
                    return result;
                }
                if (client.IsReadOnly)
                {
                    result.AddError(ErrorCode.ValidationError, "Cannot Delete Default System Client");
                    return result;
                }
                client.UpdateStatus(RecordStatus.Deleted);
                client.UpdateAudit(_session.GetString("user"));

                _client.Update(client);
            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}
