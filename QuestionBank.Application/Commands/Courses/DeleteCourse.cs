using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Courses
{
    public class DeleteCourse : IRequest<OperationResult<bool>>
    {
        public long Id { get; set; }
    }
    internal class DeleteCourseHandler : IRequestHandler<DeleteCourse, OperationResult<bool>>
    {
        private readonly IRepositoryBase<Course> _course;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public DeleteCourseHandler(IRepositoryBase<Course> course, IHttpContextAccessor httpContextAccessor)
        {
            _course = course;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<bool>> Handle(DeleteCourse request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<bool>();
            try
            {
                var course = _course.Find(request.Id);
                if (course is null)
                {
                    result.AddError(ErrorCode.NotFound, "Course not found");
                    return result;
                }
                if (course.IsReadOnly)
                {
                    result.AddError(ErrorCode.ValidationError, "Cannot Delete Default System Course");
                    return result;
                }
                course.UpdateStatus(RecordStatus.Deleted);
                course.UpdateAudit(_session.GetString("user"));

                _course.Update(course);
            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
    }
}
