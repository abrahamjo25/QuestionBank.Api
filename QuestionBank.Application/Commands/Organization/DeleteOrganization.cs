using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;

namespace QuestionBank.Application.Commands;
public class DeleteOrganization : IRequest<OperationResult<bool>>
{
    public long Id { get; set; }
}
internal class DeleteOrganizationHandler : IRequestHandler<DeleteOrganization, OperationResult<bool>>
{
    private readonly IRepositoryBase<Organization> _organization;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ISession _session => _httpContextAccessor.HttpContext.Session;
    public DeleteOrganizationHandler(IRepositoryBase<Organization> organization, IHttpContextAccessor httpContextAccessor)
    {

        _organization = organization;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<OperationResult<bool>> Handle(DeleteOrganization request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<bool>();
        var organization = await _organization.FirstOrDefaultAsync(x => x.Id == request.Id);
        if (organization is null)
        {
            result.AddError(ErrorCode.NotFound, "Organization not found");
            return result;
        }
        if (organization.IsReadOnly)
        {
            result.AddError(ErrorCode.ValidationError, "Cannot Delete Default Data");
            return result;
        }
        organization.Delete();
        _organization.Update(organization);

        result.Message = "Operation success";
        return result;
    }
}
