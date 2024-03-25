using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.Courses
{
    public class GetCourseById : IRequest<OperationResult<Course>>
    {
        public long Id { get; set; }
    }
    internal class GetClienByIdtQueryHandler : IRequestHandler<GetCourseById, OperationResult<Course>>
    {
        private readonly IRepositoryBase<Course> _course;
        public GetClienByIdtQueryHandler(IRepositoryBase<Course> course)
        {
            _course = course;
        }
        public async Task<OperationResult<Course>> Handle(GetCourseById request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Course>();
            try
            {
                var course = await _course.FirstOrDefaultAsync(x => x.Id == request.Id && x.RecordStatus == RecordStatus.Active);

                if (course is null)
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
