using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands;
public class UpdateOrganizationStatus : IRequest<OperationResult<Organization>>
{
    public long Id { get; set; }
    public RecordStatus Status { get; set; }
}
internal class UpdateOrganizationStatusHandler : IRequestHandler<UpdateOrganizationStatus, OperationResult<Organization>>
{
    private readonly IRepositoryBase<Organization> _organization;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ISession _session => _httpContextAccessor.HttpContext.Session;
    public UpdateOrganizationStatusHandler(IRepositoryBase<Organization> subscription, IHttpContextAccessor httpContextAccessor)
    {
        _organization = subscription;
        _httpContextAccessor = httpContextAccessor;
    }
    public async Task<OperationResult<Organization>> Handle(UpdateOrganizationStatus request, CancellationToken cancellationToken)
    {
        var result = new OperationResult<Organization>();
        try
        {
            var subscription = await _organization.FirstOrDefaultAsync(s => s.Id == request.Id && s.RecordStatus != RecordStatus.Deleted);
            if (subscription is null)
            {
                result.AddError(ErrorCode.NotFound, "Organization not found!");
                return result;
            }

            subscription.UpdateRecordStatus(request.Status);
            _organization.Update(subscription);

            result.Payload = subscription;
            result.Message = "Operation Success";

            return result;

        }
        catch (Exception ex)
        {
            result.AddError(ErrorCode.ServerError, ex.Message);
        }

        return result;
    }
}
