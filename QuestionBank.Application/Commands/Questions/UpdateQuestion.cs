using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.Questions
{
    public class UpdateQuestion : IRequest<OperationResult<Question>>
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string Explanation { get; set; }
        public long ModuleId { get; set; }

    }
    internal class UpdateQuestionHandler : IRequestHandler<UpdateQuestion, OperationResult<Question>>
    {
        private readonly IRepositoryBase<Question> _question;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateQuestionHandler(IRepositoryBase<Question> question, IHttpContextAccessor httpContextAccessor)
        {
            _question = question;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Question>> Handle(UpdateQuestion request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Question>();

            try
            {
                var question = await _question.FindAsync(request.Id);

                if (question is null)
                {
                    result.AddError(ErrorCode.NotFound, "Question Not found!");
                    return result;
                }

                question.Update(request.Text, request.Explanation, request.ModuleId);
                question.UpdateAudit(_session.GetString("user"));
                _question.Update(question);
                result.Payload = question;
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
