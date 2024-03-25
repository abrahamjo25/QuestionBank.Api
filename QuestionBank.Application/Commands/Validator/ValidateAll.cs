using Identity.Application.Helpers.Dtos;
using MediatR;
using QuestionBank.Application.Helpers.Common;
using System.Security.Claims;

namespace Identity.Application.Commands.Validator
{
    public class ValidateAll : IRequest<OperationResult<UserTokenValidationResponse>>
    {
        public string AccessToken { get; set; }
        public string IdToken { get; set; }
        public string ApiResource { get; set; }
        public string ClientResource { get; set; }
        public long ServiceId { get; set; }
        public string OrganizationCode { get; set; }
        public bool IsMultiTenant { get; set; }
        public bool IsCompany { get; set; }
        public string CompanyCode { get; set; }


    }
    internal class ValidateAllHandler : IRequestHandler<ValidateAll, OperationResult<UserTokenValidationResponse>>
    {
        private readonly ITokenhandler _tokenHandler;
        private readonly IMediator _mediator;
        public ValidateAllHandler(ITokenhandler tokenHandler, IMediator mediator)
        {
            _tokenHandler = tokenHandler;
            _mediator = mediator;
        }

        public async Task<OperationResult<UserTokenValidationResponse>> Handle(ValidateAll request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<UserTokenValidationResponse>();
            var tokenValidationResponse = new UserTokenValidationResponse { ClientId = "", UserId = "" , IsCompany = false, CompanyCode = ""};

            try
            {
                bool isonlyClient = false;
                var isValid = await _mediator.Send(new ValidateClient
                {
                    AccessToken = request.AccessToken,
                    ApiResource = request.ApiResource,
                    ServiceId = request.ServiceId,
                    
                });
                if (isValid.IsError)
                {
                    isValid.Errors.ForEach(e => result.AddError(e.Code, e.Message));
                    return result;
                }
                if (isValid.Payload.RequireIdToken)
                {
                    if (!await _tokenHandler.ValidateToken(request.IdToken)) //decrypt and validate Id token
                    {
                        result.AddError(ErrorCode.UnAuthorized, "Id token is invalid.");
                        return result;
                    }
                    var claims = await _tokenHandler.GetClaims(request.IdToken);
                    if (!_authorizeTokenClaim(claims, request.ServiceId, request.ClientResource, ref isonlyClient)) // check if token is alllowed to access claimed client resource
                    {
                        result.AddError(ErrorCode.UnAuthorized, "User is not Authorized to access.");
                        return result;
                    }
                    var userName = claims.Where(x => x.Type == "userName").FirstOrDefault();
                    var CompanyCode = claims.Where(c => c.Type == "CompanyCode").FirstOrDefault();
                    var IsCompany = claims.Where(c => c.Type == "IsCompany").FirstOrDefault();
                    //var company = request.IsCompany;//  claims.Where(x => x.Type == "IsCompany").FirstOrDefault();
                    if (userName is not null)
                    {
                        tokenValidationResponse.ClientId = isValid.Payload.ClientId;
                        tokenValidationResponse.UserId = userName.Value;
                        tokenValidationResponse.CompanyCode = CompanyCode.Value;
                        tokenValidationResponse.IsCompany = Convert.ToBoolean(IsCompany.Value);
                        //tokenValidationResponse.IsCompany = isValid;
                    }

                    if (request.IsMultiTenant)
                    {
                        var organizations = claims.Where(x => x.Type == "ORGS").Select(x => x.Value).ToList();
                        if (organizations.Contains(request.OrganizationCode))
                        {
                            tokenValidationResponse.Tenant = request.OrganizationCode;
                        }
                        else
                        {
                            result.AddError(ErrorCode.UnAuthorized, "User is not authorized to access the Tenant.");
                            return result;
                        }

                    }
                }
                tokenValidationResponse.ClientId = isValid.Payload.ClientId;
                result.Payload = tokenValidationResponse;
                return result;
            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
                return result;
            }
            return result;
        }
        private bool _authorizeTokenClaim(List<Claim> claims, long serviceId, string resource, ref bool isonlyClient)
        {
            var requiredClaim = string.Format("{0}", resource).ToLower();
            var claim = claims.Where(x => x.Value.ToLower() == requiredClaim).FirstOrDefault();
            if (claim is null)
                return false;
            var claimDetail = claim.Value.Split("#");
            string requireIdToken = claimDetail.Count() == 3 ? claimDetail[2] : "false";
            isonlyClient = requireIdToken == "true";
            return true;
        }
    }
}

