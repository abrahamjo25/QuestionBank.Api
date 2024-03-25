using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.Shared;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Application.Commands.ClientClaims
{
    public class UpdateClientClaimStatus : IRequest<OperationResult<ClientClaim>>
    {
        public long Id { get; set; }
        public RecordStatus RecordStatus { get; set; }

    }
    internal class UpdateClientClaimStatusHandler : IRequestHandler<UpdateClientClaimStatus, OperationResult<ClientClaim>>
    {
        private readonly IRepositoryBase<ClientClaim> _clientClaim;
        private readonly IPassword _passwordService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateClientClaimStatusHandler(IRepositoryBase<ClientClaim> clientClaim, IPassword passwordService, IHttpContextAccessor httpContextAccessor)
        {
            _clientClaim = clientClaim;
            _passwordService = passwordService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<OperationResult<ClientClaim>> Handle(UpdateClientClaimStatus request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<ClientClaim>();
            try
            {
                bool success = Enum.IsDefined(typeof(RecordStatus), request.RecordStatus);
                if (!success)
                {
                    result.AddError(ErrorCode.NotFound, "The Given Record status is not defined");
                    return result;
                }

                var clientClaim = _clientClaim.Find(request.Id);
                if (clientClaim is null)
                {
                    result.AddError(ErrorCode.NotFound, "No Client claim found,");
                    return result;
                }          
                clientClaim.UpdateStatus((RecordStatus)request.RecordStatus);
                clientClaim.UpdateAudit(_session.GetString("user"));
                _clientClaim.Update(clientClaim);

                result.Payload = clientClaim;
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