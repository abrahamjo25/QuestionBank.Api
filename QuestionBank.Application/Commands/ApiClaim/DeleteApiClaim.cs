using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.Clients;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.ApiClaims
{
    public class DeleteApiClaim : IRequest<OperationResult<bool>>
    {
        public long Id { get; set; }
    }
    internal class ApiClamDeleteHandler : IRequestHandler<DeleteApiClaim, OperationResult<bool>>
    {
        private readonly IRepositoryBase<ApiClaim> _apiClaim;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public ApiClamDeleteHandler(IRepositoryBase<ApiClaim> apiClaim, IHttpContextAccessor httpContextAccessor)
        {
            _apiClaim = apiClaim;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<OperationResult<bool>> Handle(DeleteApiClaim request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<bool>();
            try
            {
                var apiClaim = await _apiClaim.FirstOrDefaultAsync(x => x.Id == request.Id&& x.RecordStatus != RecordStatus.Deleted);
                if (apiClaim is null)
                {
                    result.AddError(ErrorCode.NotFound, "Api claim not found");
                    return result;
                }
                if (apiClaim.IsReadOnly)
                {
                    result.AddError(ErrorCode.ValidationError, "Cannot Delete Default System Data");
                    return result;
                }
                apiClaim.UpdateAudit(_session.GetString("user"));
                apiClaim.RecordStatus = RecordStatus.Deleted;
                _apiClaim.Update(apiClaim);     
                return result;



            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}
