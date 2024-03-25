using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Application.Commands.ClientClaims
{
    public class CreateClientClaim : IRequest<OperationResult<ClientClaim>>
    {
        public string Name { get; private set; }
        public string Claim { get; private set; }
        public string Description { get; private set; }
        public long ClientId { get; private set; }

    }
    public class CreateClinetClaimHandler : IRequestHandler<CreateClientClaim, OperationResult<ClientClaim>>
    {
        private readonly IRepositoryBase<ClientClaim> _clientClaim;
        private readonly IPassword _passwordService;
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateClinetClaimHandler(IRepositoryBase<ClientClaim> clientClaim, IMapper mapper, IPassword passwordService, IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
       
            _clientClaim = clientClaim;
            _mediator = mediator;
            _passwordService = passwordService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<OperationResult<ClientClaim>> Handle(CreateClientClaim request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<ClientClaim>();
            try
            {
                var clientClaim = ClientClaim.Create(request.Name, request.Claim, request.Description, request.ClientId);
                var res=await _clientClaim.AddAsync(clientClaim);
                if (res is false)
                {
                    result.AddError(ErrorCode.UnknownError, "Unable to Create Client Claim");
                    return result;
                }
                result.Payload = clientClaim;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;
        }
    }
}

