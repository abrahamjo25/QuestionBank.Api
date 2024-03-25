using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Choices
{
    public class GetChoiceById : IRequest<OperationResult<Choice>>
    {
        public long Id { get; set; }
    }
    internal class GetClienByIdtQueryHandler : IRequestHandler<GetChoiceById, OperationResult<Choice>>
    {
        private readonly IRepositoryBase<Choice> _choice;
        public GetClienByIdtQueryHandler(IRepositoryBase<Choice> choice)
        {
            _choice = choice;
        }
        public async Task<OperationResult<Choice>> Handle(GetChoiceById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Choice>();
            try
            {
                var choice = await _choice.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus == RecordStatus.Active);

                if (choice is null)
                {
                    result.AddError(ErrorCode.NotFound, "Choice is not found!");
                    return result;
                }
                result.Payload = choice;
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
