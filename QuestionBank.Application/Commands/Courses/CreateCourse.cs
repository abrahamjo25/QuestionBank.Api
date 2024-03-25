using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Application.Commands.Courses
{
    public class CreateCourse : IRequest<OperationResult<Course>>
    {
        public string CourseName { get; private set; }
        public string Description { get; private set; }
    }
    internal class CreateClinetHandler : IRequestHandler<CreateCourse, OperationResult<Course>>
    {
        private readonly IRepositoryBase<Course> _course;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreateClinetHandler(IRepositoryBase<Course> course, IHttpContextAccessor httpContextAccessor)
        {
            _course = course;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Course>> Handle(CreateCourse request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<Course>();
            try
            {

                var course = Course.Create(request.CourseName, request.Description);
                course.Register(_session.GetString("user"));

                await _course.AddAsync(course);

                result.Payload = course;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;

        }
    }
}
