using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Application.Commands.ClientClaims
{
    public class DeleteClientClaim : IRequest<OperationResult<bool>>
    {
        public long Id { get; set; }
    }
    internal class DeleteClientClaimHandler : IRequestHandler<DeleteClientClaim, OperationResult<bool>>
    {
        private readonly IRepositoryBase<ClientClaim> _clientClaim;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public DeleteClientClaimHandler(IRepositoryBase<ClientClaim> clientClaim, IHttpContextAccessor httpContextAccessor)
        {
            _clientClaim = clientClaim;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<OperationResult<bool>> Handle(DeleteClientClaim request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<bool>();
            try
            {
                var clieintClaim =  _clientClaim.Find(request.Id);
                if (clieintClaim is null)
                {
                    result.AddError(ErrorCode.NotFound, "Client claim not found");
                    return result;
                }
                if (clieintClaim.IsReadOnly)
                {
                    result.AddError(ErrorCode.ValidationError, "Cannot Delete Default System Client Claim");
                    return result;
                }
                clieintClaim.UpdateStatus(RecordStatus.Deleted);    
                clieintClaim.UpdateAudit(_session.GetString("user"));
                _clientClaim.Update(clieintClaim);

            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}


