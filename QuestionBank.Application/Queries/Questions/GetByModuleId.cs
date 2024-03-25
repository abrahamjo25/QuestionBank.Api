using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Questions
{

    public class GetByModuleId : IRequest<OperationResult<IEnumerable<Question>>>
    {
        public long Id { get; set; }
    }
    internal class GetByModuleIdQueryHandler : IRequestHandler<GetByModuleId, OperationResult<IEnumerable<Question>>>
    {
        private readonly IRepositoryBase<Question> _question;
        private readonly IRepositoryBase<UserModule> _userModule;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public GetByModuleIdQueryHandler(IRepositoryBase<Question> question, IHttpContextAccessor httpContextAccessor, IRepositoryBase<UserModule> userModule)
        {
            _question = question;
            _httpContextAccessor = httpContextAccessor;
            _userModule = userModule;
        }
        public async Task<OperationResult<IEnumerable<Question>>> Handle(GetByModuleId request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<Question>>();
            try
            {
                var isUserSubscribed = await _userModule.FirstOrDefaultAsync(u=>u.ModuleId == request.Id  && u.Username == _session.GetString("user"));
                
                if (isUserSubscribed == null)
                {
                    result.AddError(ErrorCode.NotFound, "User has no subscription!");
                    return result;
                }
                var question = await _question.Where(x => x.ModuleId == request.Id && x.RecordStatus == RecordStatus.Active,"Choice").ToListAsync();


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
