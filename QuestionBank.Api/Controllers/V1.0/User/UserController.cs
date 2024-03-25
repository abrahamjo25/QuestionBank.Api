using QuestionBank.Api.Contracts.Subscription;
using QuestionBank.Application.Commands.Users;
using QuestionBank.Application.Queries.Users;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.User;
public class UserController : BaseController
{
    private readonly ILogger<UserController> _logger;
    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpPost("Create")]
    [ValidateModel]
    public async Task<IActionResult> CreateUser([FromBody] UserRequest clientRequest)
    {
        var command = _mapper.Map<CreateUser>(clientRequest);
        var result = await _mediator.Send(command);
        var userDetail = _mapper.Map<UserDetail>(result.Payload);

        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(userDetail);
    }
    [HttpPost("CompanyUser")]
    [ValidateModel]
    public async Task<IActionResult> CompanyUser([FromBody] CompanyRequest clientRequest)
    {
        var command = _mapper.Map<CreateUser>(clientRequest);
        var result = await _mediator.Send(command);
        var userDetail = _mapper.Map<UserDetail>(result.Payload);

        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(userDetail);
    }
    [HttpPost("ExternalCreate")]
    [ValidateModel]
    public async Task<IActionResult> ExternalCreate([FromBody] UserRequest clientRequest)
    {
        var command = _mapper.Map<CreateUser>(clientRequest);
        var result = await _mediator.Send(command);
        var userDetail = _mapper.Map<UserDetail>(result.Payload);

        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(userDetail);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> UpdateUser([FromBody] UpdateUserRequest updateUserRequest)
    {
        var command = _mapper.Map<UpdateUser>(updateUserRequest);
        var result = await _mediator.Send(command);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var query = new GetUserById { Id = id };
        var result = await _mediator.Send(query);
        var usersList = _mapper.Map<UserDetail>(result.Payload);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(usersList);
    }

    [HttpGet("GetByClientId")]
    public async Task<IActionResult> GetByClientId(long clientId)
    {
        var query = new GetByClientId { ClientId = clientId };
        var result = await _mediator.Send(query);
        var userDetail = _mapper.Map<List<UserDetail>>(result.Payload);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(userDetail);
    }
    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] UserLogin request)
    {
        var command = new LoginUser { Username = request.Username.ToUpper(), Password = request.Password };
        var result = await _mediator.Send(command);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result.Payload);
    }
    [HttpPut("ActivateDeactivateUser")]
    public async Task<IActionResult> ActivateDeactivateUser([FromBody] ActivateDeactivateUserRequest request)
    {
        var command = _mapper.Map<ActivateUser>(request);
        var result = await _mediator.Send(command);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }
    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
    {
        var query = new GetAllUsers { RecordStatus = recordStatus };
        var result = await _mediator.Send(query);
        var usersList = _mapper.Map<List<UserDetail>>(result.Payload);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(usersList);
    }


    [HttpGet("GetCompanyUsers")]
    public async Task<IActionResult> GetCompanyUsers(RecordStatus? recordStatus)
    {
        var query = new GetCompanyUsers { RecordStatus = recordStatus };
        var result = await _mediator.Send(query);
        var usersList = _mapper.Map<List<UserDetail>>(result.Payload);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(usersList);
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> DeleteUser(long id)
    {
        var query = new DeleteUser(id);
        var result = await _mediator.Send(query);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }
    [HttpGet("RefreshUserToken")]
    public async Task<IActionResult> RefreshToken(string refreshToken)
    {
        var result = await _mediator.Send(new RefreshUser { RefreshToken = refreshToken });
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }
    [HttpPost("RefreshToken")]
    public async Task<IActionResult> RefreshToken(UserRefreshTokenRequest refreshToken)
    {
        var result = await _mediator.Send(new RefreshUser { RefreshToken = refreshToken.token });
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }
    [HttpPost("AddSubscription")]
    public async Task<IActionResult> AddSubscription(UserSubscriptionDto request)
    {
        var result = await _mediator.Send(new AddUserSubscription { ClientId = request.ClientId, IsDefault = request.IsDefault, OrganizatoinId = request.OrganizatoinId, UserId = request.UserId });
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }
    [HttpDelete("DeleteSubscription")]
    public async Task<IActionResult> DeleteSubscription(long id)
    {
        var query = new DeleteUserSubscription { };
        var result = await _mediator.Send(query);
        return result.IsError ? HandleErrorResponse(result.Errors) : Ok(result);
    }
}