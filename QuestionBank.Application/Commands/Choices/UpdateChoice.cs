using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.Choices
{
    public class UpdateChoice : IRequest<OperationResult<Choice>>
    {
        public long Id { get; set; }
        public string Label { get;  set; }
        public string Text { get;  set; }
        public bool IsCorrect { get;  set; }

        public long QuestionId { get;  set; }
    }
    internal class UpdateChoiceHandler : IRequestHandler<UpdateChoice, OperationResult<Choice>>
    {
        private readonly IRepositoryBase<Choice> _choice;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateChoiceHandler(IRepositoryBase<Choice> choice, IHttpContextAccessor httpContextAccessor)
        {
            _choice = choice;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Choice>> Handle(UpdateChoice request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Choice>();

            try
            {
                var choice = await _choice.FindAsync(request.Id);

                if (choice is null)
                {
                    result.AddError(ErrorCode.NotFound, "Choice Not found!");
                    return result;
                }

                choice.Update(request.Label, request.Text,request.IsCorrect,request.QuestionId);
                choice.UpdateAudit(_session.GetString("user"));
                _choice.Update(choice);
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
