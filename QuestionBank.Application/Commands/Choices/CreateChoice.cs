using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.Choices
{
    public class CreateChoice : IRequest<OperationResult<Choice>>
    {
        public string Label { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public long QuestionId { get; set; }
    }
    internal class CreateClinetHandler : IRequestHandler<CreateChoice, OperationResult<Choice>>
    {
        private readonly IRepositoryBase<Choice> _choice;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateClinetHandler(IRepositoryBase<Choice> choice, IHttpContextAccessor httpContextAccessor)
        {
            _choice = choice;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Choice>> Handle(CreateChoice request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<Choice>();
            try
            {

                var choice = Choice.Create(request.Label, request.Text,request.IsCorrect,request.QuestionId);
                choice.Register(_session.GetString("user"));

                await _choice.AddAsync(choice);

                result.Payload = choice;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;

        }
    }
}
