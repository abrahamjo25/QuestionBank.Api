using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Modules
{
    public class NewCourseModule : IRequest<OperationResult<IEnumerable<Module>>>
    {
        public long Id { get; set; }
    }
    internal class NewCourseModuleQueryHandler : IRequestHandler<NewCourseModule, OperationResult<IEnumerable<Module>>>
    {
        private readonly IRepositoryBase<Module> _module;
        private readonly IRepositoryBase<UserModule> _userModule;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public NewCourseModuleQueryHandler(IRepositoryBase<Module> module, IRepositoryBase<UserModule> userModule, IHttpContextAccessor httpContextAccessor)
        {
            _module = module;
            _userModule = userModule;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<IEnumerable<Module>>> Handle(NewCourseModule request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<Module>>();
            try
            {
                var userModuleModuleIds = _userModule
                    .Where(x => x.Username == _session.GetString("user") && x.RecordStatus == RecordStatus.Active)
                    .Select(x => x.ModuleId)
                    .ToList();

                var module = await _module
                    .Where(x => x.CourseId == request.Id && x.RecordStatus == RecordStatus.Active && !userModuleModuleIds.Contains(x.Id))
                    .ToListAsync();


                if (module is null)
                {
                    result.AddError(ErrorCode.NotFound, "Module is not found!");
                    return result;
                }
                result.Payload = module;
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
