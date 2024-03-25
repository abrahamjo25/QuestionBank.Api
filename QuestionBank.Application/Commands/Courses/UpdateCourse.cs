using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.Courses
{
    public class UpdateCourse : IRequest<OperationResult<Course>>
    {
        public long Id { get; set; }
        public string CourseName { get; private set; }
        public string Description { get; private set; }

    }
    internal class UpdateCourseHandler : IRequestHandler<UpdateCourse, OperationResult<Course>>
    {
        private readonly IRepositoryBase<Course> _course;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public UpdateCourseHandler(IRepositoryBase<Course> course, IHttpContextAccessor httpContextAccessor)
        {
            _course = course;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Course>> Handle(UpdateCourse request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Course>();

            try
            {
                var course = await _course.FindAsync(request.Id);

                if (course is null)
                {
                    result.AddError(ErrorCode.NotFound, "Course Not found!");
                    return result;
                }

                course.Update(request.CourseName, request.Description);
                course.UpdateAudit(_session.GetString("user"));
                _course.Update(course);
                result.Payload = course;
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
