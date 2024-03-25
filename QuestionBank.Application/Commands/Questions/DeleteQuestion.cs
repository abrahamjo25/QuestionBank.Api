using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Questions
{
    public class DeleteQuestion : IRequest<OperationResult<bool>>
    {
        public long Id { get; set; }
    }
    internal class DeleteQuestionHandler : IRequestHandler<DeleteQuestion, OperationResult<bool>>
    {
        private readonly IRepositoryBase<Question> _question;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public DeleteQuestionHandler(IRepositoryBase<Question> question, IHttpContextAccessor httpContextAccessor)
        {
            _question = question;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<bool>> Handle(DeleteQuestion request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<bool>();
            try
            {
                var question = _question.Find(request.Id);
                if (question is null)
                {
                    result.AddError(ErrorCode.NotFound, "Question not found");
                    return result;
                }
                if (question.IsReadOnly)
                {
                    result.AddError(ErrorCode.ValidationError, "Cannot Delete Default System Question");
                    return result;
                }
                question.UpdateStatus(RecordStatus.Deleted);
                question.UpdateAudit(_session.GetString("user"));

                _question.Update(question);
            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}
