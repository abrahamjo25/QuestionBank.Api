using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.Questions
{
    public class CreateQuestionsWithChoice : IRequest<OperationResult<Question>>
    {
        public string Text { get; set; }
        public string Explanation { get; set; }
        public long ModuleId { get; set; }
        public List<ChoiceModelCreate> Choices { get; set; }
    }

    public class ChoiceModelCreate
    {
        public string Label { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }

    internal class CreateQuestionsWithChoiceHandler : IRequestHandler<CreateQuestionsWithChoice, OperationResult<Question>>
    {
        private readonly IRepositoryBase<Question> _questionRepository;
        private readonly IRepositoryBase<Choice> _choiceRepository;

        public CreateQuestionsWithChoiceHandler(IRepositoryBase<Question> questionRepository, IRepositoryBase<Choice> choiceRepository)
        {
            _questionRepository = questionRepository;
            _choiceRepository = choiceRepository;
        }

        public async Task<OperationResult<Question>> Handle(CreateQuestionsWithChoice request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Question>();

            try
            {
                var question = Question.Create(request.Text, request.Explanation, request.ModuleId);
                await _questionRepository.AddAsync(question);

                foreach (var choiceModel in request.Choices)
                {
                    var choice = Choice.Create(choiceModel.Label, choiceModel.Text, choiceModel.IsCorrect, question.Id);
                    await _choiceRepository.AddAsync(choice);
                }

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
