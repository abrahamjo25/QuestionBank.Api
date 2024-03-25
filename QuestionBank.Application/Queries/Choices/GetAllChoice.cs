using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Choices
{
    public class GetAllChoice : IRequest<OperationResult<IEnumerable<Choice>>>
    {
        public RecordStatus? recordStatus { get; set; }
    }
    internal class GetAllChoiceQueryHandler : IRequestHandler<GetAllChoice, OperationResult<IEnumerable<Choice>>>
    {
        private readonly IRepositoryBase<Choice> _choice;
        public GetAllChoiceQueryHandler(IRepositoryBase<Choice> choice)
        {
            _choice = choice;
        }

        public async Task<OperationResult<IEnumerable<Choice>>> Handle(GetAllChoice request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<Choice>>();
            try
            {

                var choice = request.recordStatus switch
                {
                    RecordStatus.Active => _choice.Where(x => x.RecordStatus == RecordStatus.Active).ToList(),
                    RecordStatus.InActive => _choice.Where(x => x.RecordStatus == RecordStatus.InActive).ToList(),
                    _ => _choice.Where(x => x.RecordStatus != RecordStatus.Deleted).ToList(),
                };

                if (choice is null || choice.Count == 0)
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

