using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.Questions
{
    public class CreateQuestion : IRequest<OperationResult<Question>>
    {
        public string Text { get;  set; }
        public string Explanation { get;  set; }
        public long ModuleId { get;  set; }
    }
    internal class CreateClinetHandler : IRequestHandler<CreateQuestion, OperationResult<Question>>
    {
        private readonly IRepositoryBase<Question> _question;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateClinetHandler(IRepositoryBase<Question> question, IHttpContextAccessor httpContextAccessor)
        {
            _question = question;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Question>> Handle(CreateQuestion request, CancellationToken cancellationToken)
       {

            var result = new OperationResult<Question>();
            try
            {

                var question = Question.Create(request.Text, request.Explanation, request.ModuleId);
                question.Register(_session.GetString("user"));

                await _question.AddAsync(question);

                result.Payload = question;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;

        }
    }
}
