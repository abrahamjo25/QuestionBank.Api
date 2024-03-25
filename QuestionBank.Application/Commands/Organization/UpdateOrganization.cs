using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;

namespace QuestionBank.Application.Commands
{
    public class UpdateOrganization : IRequest<OperationResult<Organization>>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public long SubscriptionId { get; set; }
    }
    internal class UpdateOrganizationHandler : IRequestHandler<UpdateOrganization, OperationResult<Organization>>
    {
        private readonly IRepositoryBase<Organization> _organization;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateOrganizationHandler(IRepositoryBase<Organization> organization, IHttpContextAccessor htstpContextAccessor)
        {
            _organization = organization;
            _httpContextAccessor = htstpContextAccessor;
        }
        public async Task<OperationResult<Organization>> Handle(UpdateOrganization request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Organization>();
            var orgainzation = await _organization.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (orgainzation == null)
            {
                result.AddError(ErrorCode.NotFound, "Organization not found found!");
                return result;
            }
            if (_organization.ExistWhere(s => s.Name == request.Name && s.Id != request.Id))
            {
                result.AddError(ErrorCode.RecordExist, "Organization already sexist");
                return result;
            }
            orgainzation.Update(request.Name, request.Description, request.Logo, request.SubscriptionId);
            _organization.Update(orgainzation);

            result.Payload = orgainzation;
            result.Message = "Operation success";
            return result;

        }
    }
}
