using QuestionBank.Domain.Models.Clients;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
namespace QuestionBank.Application.Commands.Services
{
    public class CreateService : IRequest<OperationResult<Unit>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ApiClaims { get; set; } = string.Empty;
    }

    internal class CreateServiceCommandHandler : IRequestHandler<CreateService, OperationResult<Unit>>
    {
        private readonly IRepositoryBase<Service> _service;
        private readonly IRepositoryBase<ApiClaim> _apiClaim;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateServiceCommandHandler(IRepositoryBase<Service> service, IRepositoryBase<ApiClaim> apiClaim, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _apiClaim = apiClaim;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Unit>> Handle(CreateService request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Unit>();
            var service = new Service();
            try
            {
                service = await _service.FirstOrDefaultAsync(s => s.Name == request.Name);
                if (service is null)
                {
                    service = Service.Create(request.Name, request.Description);
                    service.Register(_session.GetString("user"));
                    _service.Add(service);
                    result.Message = "Service Created";
                }

                if (!string.IsNullOrEmpty(request.ApiClaims))
                {
                    await AddClaimsToService(service.Id, request.ApiClaims, result);
                }
                return result;

            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }

            return result;
        }

        private async Task<OperationResult<Unit>> AddClaimsToService(long serviceID, string Claims, OperationResult<Unit> result)
        {
            var apiClaims = new List<ApiClaim>();
            var claimstring = Claims.Split(',');
            foreach (var list in claimstring)
            {
                var claimList = list.Split('/');
                await CheckForStringLength(claimList, result);

                var claim = claimList[0];
                bool requiredToken = Convert.ToBoolean(claimList[1]);
                var apiClaim = ApiClaim.Create(claim, serviceID, requiredToken);

                if (_apiClaim.ExistWhere(a => a.Claim == apiClaim.Claim && a.ServiceId == apiClaim.ServiceId))
                {
                    continue;
                }
                apiClaim.Register(_session.GetString("user"));
                apiClaims.Add(apiClaim);
            }

            await CreateServiceClaim(apiClaims, result);

            result.Payload = Unit.Value;
            return result;
        }
        public async Task CreateServiceClaim(List<ApiClaim> apiClaims,OperationResult<Unit> result)
        {
            if (apiClaims.Count > 0)
            {
                _apiClaim.AddRange(apiClaims);
                if (result.Message == null)
                {
                    result.Message = "Claims Added";
                }
            }
            else
            {
                if (result.Message == null)
                {
                    result.Message = "No Claim Added!";
                }
            }
        }
        private async Task<OperationResult<Unit>> CheckForStringLength(string[] Claims, OperationResult<Unit> result)
        {
            if (Claims.Length != 2)
            {
                result.AddError(ErrorCode.ValidationError, "Claim data format invalid.");
                return result;
            }
            return result;
        }
    }
}
