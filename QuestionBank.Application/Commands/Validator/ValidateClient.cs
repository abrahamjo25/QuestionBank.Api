using Identity.Application.Helpers.Dtos;
using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Application.Helpers.Dtos;
using System.Security.Claims;

namespace Identity.Application.Commands.Validator;

public class ValidateClient : IRequest<OperationResult<ClientTokenValidationResponse>>
{
    public string AccessToken { get; set; } = String.Empty;
    public string ApiResource { get; set; } = String.Empty;
    public long ServiceId { get; set; }
}
internal class ValidateClientHandler : IRequestHandler<ValidateClient, OperationResult<ClientTokenValidationResponse>>
{
    private readonly ITokenhandler _tokenHandler;
    public ValidateClientHandler(ITokenhandler tokenHandler)
    {
        _tokenHandler = tokenHandler;
    }
    public async Task<OperationResult<ClientTokenValidationResponse>> Handle(ValidateClient request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<ClientTokenValidationResponse>();
        var tokenValidationResponse = new ClientTokenValidationResponse { ClientId = "", RequireIdToken = true };
        try
        {
            if (!await _tokenHandler.ValidateToken(request.AccessToken)) //decrypt and validate access token
            {
                result.AddError(ErrorCode.UnAuthorized, "Client token is invalid.");
                return result;
            }
            var claims = await _tokenHandler.GetClaims(request.AccessToken); // get claims from the token
            if (!_authorizeAccessToken(claims, request.ServiceId, request.ApiResource, ref tokenValidationResponse)) // check if token is alllowed to access claimed api resource
            {
                result.AddError(ErrorCode.UnAuthorized, "Client is not Authorized.");
                return result;
            }
            var clientIdClaim = claims.Where(x => x.Type == "clientId").FirstOrDefault();
            if (clientIdClaim is not null)
                tokenValidationResponse.ClientId = clientIdClaim.Value;
            result.Payload = tokenValidationResponse;
            return result;

        }
        catch (Exception e)
        {
            result.AddError(ErrorCode.ServerError, e.Message);
        }

        return result;
    }

    private bool _authorizeAccessToken(List<Claim> claims, long serviceId, string apiResource, ref ClientTokenValidationResponse response)
    {
        var requiredClaim = string.Format("{0}#{1}", serviceId, apiResource).ToLower();
        var claim = claims.Where(x => x.Value.ToLower().StartsWith(requiredClaim)).FirstOrDefault();
        if (claim is null)
            return false;
        var requireToken = claim.Value.Split("#");
        var doesRequireIdToken = (requireToken.Length == 3 ? requireToken[2].ToLower() : "true");
        response.RequireIdToken = (doesRequireIdToken == "true");
        return true;
    }
}
