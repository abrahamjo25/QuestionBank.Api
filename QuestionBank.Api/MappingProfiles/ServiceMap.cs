using AutoMapper;
using QuestionBank.Api.Contracts.Service.Request;
using QuestionBank.Api.Contracts.Service.Response;
using QuestionBank.Application.Commands;
using QuestionBank.Application.Commands.Services;
using QuestionBank.Domain.Models;

namespace QuestionBank.Api.MappingProfiles;
public class ServiceMap : Profile
{
    public ServiceMap()
    {
        CreateMap<Service, ServiceDetailDto>()
            .ForMember(s => s.ServiceClaims, y => y.MapFrom(src => src.ApiClaims));
        CreateMap<ServiceRequest, CreateService>();
        CreateMap<ServiceRequest, UpdateService>();
        CreateMap<ActivateDeactivateServiceRequest, UpdateSubscriptionStatus>();
        
    }
}
