using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Application.Commands.ClientClaims
{
    public class UpdateClientClaim : IRequest<OperationResult<ClientClaim>>
    {
        public long Id { get; set; }
        public string Name { get; private set; }
        public string Claim { get; private set; }
        public string Description { get; private set; }
        public long ClientId { get; private set; }
    }
    internal class UpdateClientClaimHandler : IRequestHandler<UpdateClientClaim, OperationResult<ClientClaim>>
    {
        private readonly IRepositoryBase<ClientClaim> _clientClaim;
        private readonly IPassword _passwordService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateClientClaimHandler(IRepositoryBase<ClientClaim> clientClaim, IPassword passwordService, IHttpContextAccessor httpContextAccessor)
        {
            _clientClaim = clientClaim;
            _passwordService = passwordService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<OperationResult<ClientClaim>> Handle(UpdateClientClaim request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<ClientClaim>();
            try
            {
                var clientClaim = _clientClaim.Find(request.Id);
                if (clientClaim is null)
                {
                    result.AddError(ErrorCode.NotFound, "No Client claim found,");
                    return result;
                }
                clientClaim.Update(request.Name, request.Claim, request.Description, request.ClientId);
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