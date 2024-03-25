using AutoMapper;
using QuestionBank.Api.Contracts.Choices.Request;
using QuestionBank.Api.Contracts.Choices.Response;
using QuestionBank.Api.Contracts.Courses.Request;
using QuestionBank.Api.Contracts.Courses.Response;
using QuestionBank.Api.Contracts.ExamResults.Request;
using QuestionBank.Api.Contracts.Modules.Request;
using QuestionBank.Api.Contracts.Modules.Response;
using QuestionBank.Api.Contracts.Payments;
using QuestionBank.Api.Contracts.Questions.Request;
using QuestionBank.Api.Contracts.Questions.Response;
using QuestionBank.Application.Commands.Choices;
using QuestionBank.Application.Commands.Courses;
using QuestionBank.Application.Commands.ExamResults;
using QuestionBank.Application.Commands.Modules;
using QuestionBank.Application.Commands.Payment;
using QuestionBank.Application.Commands.Questions;
using QuestionBank.Domain.Models.QuestionBanks;

namespace QuestionBank.Api.MappingProfiles
{
    public class QuestionBankMap : Profile
    {
        public QuestionBankMap()
        {

            //Course
            CreateMap<Course, CourseDetail>();
            CreateMap<CourseCreateRequest, CreateCourse>();
            CreateMap<CourseUpdateRequest, UpdateCourse>();

            //Module
            CreateMap<Module, ModuleDetail>();
            CreateMap<ModuleCreateRequest, CreateModule>();
            CreateMap<ModuleUpdateRequest, UpdateModule>();

            //Question
            CreateMap<Question, QuestionDetail>();
            CreateMap<QuestionCreateRequest, CreateQuestion>();
            CreateMap<QuestionUpdateRequest, UpdateQuestion>();

            //Choice
            CreateMap<Choice, ChoiceDetail>();
            CreateMap<ChoiceCreateRequest, CreateChoice>();
            CreateMap<ChoiceUpdateRequest, UpdateChoice>();

            CreateMap<QuestionsWithChoicesCreate, CreateQuestionsWithChoice>()
               .ForMember(dest => dest.Choices, opt => opt.MapFrom(src => src.Choices));
            CreateMap<ChoiceDtoCreate, ChoiceModelCreate>();

            CreateMap<QuestionsWithChoicesUpdate, UpdateQuestionsWithChoice>()
               .ForMember(dest => dest.Choices, opt => opt.MapFrom(src => src.Choices));
            CreateMap<ChoiceDtoUpdate, ChoiceUpdateModel>();

            //Exam Result
            CreateMap<ExamResultCreateRequest, CreateExamResult>();

            //Payment
            CreateMap<PaymentCreateRequest, CreatePayment>();
        }
    }
}
