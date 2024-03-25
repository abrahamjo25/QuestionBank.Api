using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Questions
{
    public class GetAllQuestion : IRequest<OperationResult<IEnumerable<Question>>>
    {
        public RecordStatus? recordStatus { get; set; }
    }
    internal class GetAllQuestionQueryHandler : IRequestHandler<GetAllQuestion, OperationResult<IEnumerable<Question>>>
    {
        private readonly IRepositoryBase<Question> _questions;
        public GetAllQuestionQueryHandler(IRepositoryBase<Question> questions)
        {
            _questions = questions;
        }

        public async Task<OperationResult<IEnumerable<Question>>> Handle(GetAllQuestion request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<Question>>();
            try
            {

                var questions = request.recordStatus switch
                {
                    RecordStatus.Active => _questions.Where(x => x.RecordStatus == RecordStatus.Active, "Choice").ToList(),
                    RecordStatus.InActive => _questions.Where(x => x.RecordStatus == RecordStatus.InActive, "Choice").ToList(),
                    _ => _questions.Where(x => x.RecordStatus != RecordStatus.Deleted, "Choice").ToList(),
                };

                if (questions is null || questions.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "Question is not found!");
                    return result;
                }
                result.Payload = questions;
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
