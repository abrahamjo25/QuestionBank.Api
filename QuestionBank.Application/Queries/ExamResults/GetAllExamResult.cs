using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.ExamResults
{
    public class GetAllExamResult : IRequest<OperationResult<IEnumerable<ExamResult>>>
    {
        public long ModuleId { get; set; }
    }

    internal class GetAllExamResultQueryHandler : IRequestHandler<GetAllExamResult, OperationResult<IEnumerable<ExamResult>>>
    {
        private readonly IRepositoryBase<ExamResult> _examResult;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public GetAllExamResultQueryHandler(IRepositoryBase<ExamResult> examResult, IHttpContextAccessor httpContextAccessor)
        {
            _examResult = examResult;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<OperationResult<IEnumerable<ExamResult>>> Handle(GetAllExamResult request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<ExamResult>>();
            try
            {

                var examResult = _examResult.Where(x => x.UserModuleId == request.ModuleId && x.UserId == _session.GetString("user") && x.RecordStatus != RecordStatus.Deleted,"UserModule").ToList();
                

                if (examResult is null || examResult.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "Exam Result is not found!");
                    return result;
                }
                result.Payload = examResult;
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
