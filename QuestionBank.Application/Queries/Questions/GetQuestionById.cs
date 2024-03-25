using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Questions
{
    public class GetQuestionById : IRequest<OperationResult<Question>>
    {
        public long Id { get; set; }
    }
    internal class GetClienByIdtQueryHandler : IRequestHandler<GetQuestionById, OperationResult<Question>>
    {
        private readonly IRepositoryBase<Question> _question;
        public GetClienByIdtQueryHandler(IRepositoryBase<Question> question)
        {
            _question = question;
        }
        public async Task<OperationResult<Question>> Handle(GetQuestionById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Question>();
            try
            {
                var question = await _question.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus == RecordStatus.Active);

                if (question is null)
                {
                    result.AddError(ErrorCode.NotFound, "Question is not found!");
                    return result;
                }
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
