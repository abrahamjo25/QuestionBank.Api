using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Courses
{
    public class GetAllCourse : IRequest<OperationResult<IEnumerable<Course>>>
    {
        public RecordStatus? recordStatus { get; set; }
    }
    internal class GetAllCourseQueryHandler : IRequestHandler<GetAllCourse, OperationResult<IEnumerable<Course>>>
    {
        private readonly IRepositoryBase<Course> _course;
        public GetAllCourseQueryHandler(IRepositoryBase<Course> course)
        {
            _course = course;
        }

        public async Task<OperationResult<IEnumerable<Course>>> Handle(GetAllCourse request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<Course>>();
            try
            {

                var course = request.recordStatus switch
                {
                    RecordStatus.Active => _course.Where(x => x.RecordStatus == RecordStatus.Active).ToList(),
                    RecordStatus.InActive => _course.Where(x => x.RecordStatus == RecordStatus.InActive).ToList(),
                    _ => _course.Where(x => x.RecordStatus != RecordStatus.Deleted).ToList(),
                };

                if (course is null || course.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "Course is not found!");
                    return result;
                }
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
