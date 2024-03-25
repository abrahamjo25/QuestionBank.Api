using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Choices
{
    public class DeleteChoice : IRequest<OperationResult<bool>>
    {
        public long Id { get; set; }
    }
    internal class DeleteChoiceHandler : IRequestHandler<DeleteChoice, OperationResult<bool>>
    {
        private readonly IRepositoryBase<Choice> _choice;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public DeleteChoiceHandler(IRepositoryBase<Choice> choice, IHttpContextAccessor httpContextAccessor)
        {
            _choice = choice;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<bool>> Handle(DeleteChoice request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<bool>();
            try
            {
                var choice = _choice.Find(request.Id);
                if (choice is null)
                {
                    result.AddError(ErrorCode.NotFound, "Choice not found");
                    return result;
                }
                if (choice.IsReadOnly)
                {
                    result.AddError(ErrorCode.ValidationError, "Cannot Delete Default System Choice");
                    return result;
                }
                choice.UpdateStatus(RecordStatus.Deleted);
                choice.UpdateAudit(_session.GetString("user"));

                _choice.Update(choice);
            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}
