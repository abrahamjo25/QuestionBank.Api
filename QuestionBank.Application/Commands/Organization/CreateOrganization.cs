using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands;
public class CreateOrganization : IRequest<OperationResult<Organization>>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Logo { get; set; }
    public long SubscriptionId { get; set; }
}
internal class CreateOrganizationCommandHandler : IRequestHandler<CreateOrganization, OperationResult<Organization>>
{
    private readonly IRepositoryBase<Organization> _organization;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ISession _session => _httpContextAccessor.HttpContext.Session;
    public CreateOrganizationCommandHandler(IRepositoryBase<Organization> organization, IHttpContextAccessor httpContextAccessor)
    {
        _organization = organization;
        _httpContextAccessor = httpContextAccessor;
    }
    public async Task<OperationResult<Organization>> Handle(CreateOrganization request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Organization>();
        var existingOrganiztion = await _organization.FirstOrDefaultAsync(s => s.Name == request.Name && s.RecordStatus != RecordStatus.Deleted);
        if (existingOrganiztion is not null)
        {
            result.AddError(ErrorCode.RecordExist, "Organization already exist.");
            return result;
        }
        var organization = Organization.Create(request.Name, request.Description, request.Logo, request.SubscriptionId);
        result.Payload = organization;
        result.Message = "Operation success";
        return result;
    }
}
