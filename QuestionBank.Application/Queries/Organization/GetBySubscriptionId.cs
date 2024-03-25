using QuestionBank.Domain.Models.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;
using Microsoft.EntityFrameworkCore;
namespace QuestionBank.Application.Queries.Roles;
public class GetBySubscriptionId : IRequest<OperationResult<List<Organization>>>
{
    public long SubscriptonId { get; set; }
}
internal class GetBySubscriptionIdHandler : IRequestHandler<GetBySubscriptionId, OperationResult<List<Organization>>>
{
    private readonly IRepositoryBase<Organization> _organization;
    public GetBySubscriptionIdHandler(IRepositoryBase<Organization> organization)
    {
        _organization = organization;
    }

    public async Task<OperationResult<List<Organization>>> Handle(GetBySubscriptionId request, CancellationToken cancellationToken)
    {

        var result = new OperationResult<List<Organization>>();
        try
        {

            var organization = await _organization.Where(x => x.RecordStatus != RecordStatus.Deleted && x.SubscriptionId == request.SubscriptonId).ToListAsync();
            if (organization.Count == 0)
            {
                result.AddError(ErrorCode.NotFound, "No Organiztion data!");
                return result;
            }
            result.Payload = organization;
            return result;

        }
        catch (Exception ex)
        {
            result.AddError(ErrorCode.ServerError, ex.Message);
        }
        return result;
    }
}
