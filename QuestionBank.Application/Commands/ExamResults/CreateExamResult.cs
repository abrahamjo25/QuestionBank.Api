using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.ExamResults
{
    public class CreateExamResult : IRequest<OperationResult<ExamResult>>
    {
        public long ModuleId { get; private set; }
        public int Result { get; private set; }
    }
    internal class CreateClinetHandler : IRequestHandler<CreateExamResult, OperationResult<ExamResult>>
    {
        private readonly IRepositoryBase<ExamResult> _examResult;
        private readonly IRepositoryBase<UserModule> _userModule;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateClinetHandler(IRepositoryBase<ExamResult> examResult, IHttpContextAccessor httpContextAccessor, IRepositoryBase<UserModule> userModule)
        {
            _examResult = examResult;
            _httpContextAccessor = httpContextAccessor;
            _userModule = userModule;
        }
        public async Task<OperationResult<ExamResult>> Handle(CreateExamResult request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<ExamResult>();
            try
            {
                var isUserSubscribed = await _userModule.FirstOrDefaultAsync(u=>u.Id == request.ModuleId  && u.Username == _session.GetString("user"));

                if (isUserSubscribed == null)
                {
                    result.AddError(ErrorCode.NotFound, "The requested module is not found.");
                    return result;
                }

                var examResult = ExamResult.Create(request.ModuleId, _session.GetString("user"), request.Result);
                examResult.Register(_session.GetString("user"));

                await _examResult.AddAsync(examResult);

                result.Payload = examResult;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;

        }
    }
}
