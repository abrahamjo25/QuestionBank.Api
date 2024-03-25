using QuestionBank.Api.Contracts.Courses.Request;
using QuestionBank.Api.Contracts.Courses.Response;
using QuestionBank.Application.Commands.Courses;
using QuestionBank.Application.Queries.Courses;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Api.Controllers.V1._0.QuestionBanks
{
    public class CourseController : BaseController
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(RecordStatus? recordStatus)
        {
            var result = await _mediator.Send(new GetAllCourse { recordStatus = recordStatus });
            var courses = _mapper.Map<List<CourseDetail>>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(courses);
        }
        [HttpPost("Create")]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] CourseCreateRequest courseRequest)
        {
            var command = _mapper.Map<CreateCourse>(courseRequest);
            var result = await _mediator.Send(command);
            var course = _mapper.Map<CourseDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(course);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetCourseById { Id = id };
            var result = await _mediator.Send(query);
            var course = _mapper.Map<CourseDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(course);

        }
        [HttpPatch("Update")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromBody] CourseUpdateRequest request)
        {
            var command = _mapper.Map<UpdateCourse>(request);
            var result = await _mediator.Send(command);
            var course = _mapper.Map<CourseDetail>(result.Payload);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok(course);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(long id)
        {
            var command = new DeleteCourse { Id = id };
            var result = await _mediator.Send(command);
            return result.IsError ? HandleErrorResponse(result.Errors) : Ok();
        }
    }
}
