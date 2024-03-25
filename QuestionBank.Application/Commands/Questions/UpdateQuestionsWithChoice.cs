using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.Questions
{
    public class UpdateQuestionsWithChoice : IRequest<OperationResult<Question>>
    {
        public long QuestionId { get; set; }
        public string Text { get; set; }
        public string Explanation { get; set; }
        public long ModuleId { get; set; }
        public List<ChoiceUpdateModel> Choices { get; set; }
    }
    public class ChoiceUpdateModel
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }

    internal class UpdateQuestionsWithChoiceHandler : IRequestHandler<UpdateQuestionsWithChoice, OperationResult<Question>>
    {
        private readonly IRepositoryBase<Question> _questionRepository;
        private readonly IRepositoryBase<Choice> _choiceRepository;

        public UpdateQuestionsWithChoiceHandler(IRepositoryBase<Question> questionRepository, IRepositoryBase<Choice> choiceRepository)
        {
            _questionRepository = questionRepository;
            _choiceRepository = choiceRepository;
        }

        public async Task<OperationResult<Question>> Handle(UpdateQuestionsWithChoice request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Question>();

            try
            {
                var question = await _questionRepository.FindAsync(request.QuestionId);

                if (question == null)
                {
                    result.AddError(ErrorCode.NotFound, "Question Not found!");
                    return result;
                }

                question.Update(request.Text, request.Explanation, request.ModuleId);

                var updatedChoices = new List<Choice>();
                foreach (var choiceModel in request.Choices)
                {
                    var choice = await _choiceRepository.FindAsync(choiceModel.Id);
                    if (choice != null)
                    {
                        choice.Update(choiceModel.Label, choiceModel.Text, choiceModel.IsCorrect, request.QuestionId);
                        updatedChoices.Add(choice);
                    }
                    else
                    {
                        // Create new choice if not found
                        choice = Choice.Create(choiceModel.Label, choiceModel.Text, choiceModel.IsCorrect, request.QuestionId);
                        await _choiceRepository.AddAsync(choice);
                    }
                }

                // Update all modified choices in bulk
                foreach (var updatedChoice in updatedChoices)
                {
                     _choiceRepository.Update(updatedChoice);
                }

                 _questionRepository.Update(question);

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
