using AutoMapper;
using QuestionBank.Api.Contracts.Client.Request;
using QuestionBank.Api.Contracts.Client.Response;
using QuestionBank.Api.Contracts.Service.Response;
using QuestionBank.Application.Commands.ClientClaims;
using QuestionBank.Application.Commands.Clients;
using QuestionBank.Application.Helpers.Dtos;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Clients;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Api.MappingProfiles
{
    public class ClientMap :Profile
    {
        public ClientMap()
        {
           
            CreateMap<ClientRequest, CreateClient>();
            CreateMap<Client, ClientDetail>();
            CreateMap<Client, ClientDetails>()
                .ForMember(x => x.ClientApiResourses, y => y.MapFrom(src => src.ClientApiResources));
            CreateMap<ApiClaim, ClientApiDetail>();

            CreateMap<ClientApiResources, ClientApiDetail>();
            CreateMap<ActivateDeactivateClientRequest, ActivateClient>();

            CreateMap<ClientUpdateRequest, UpdateClient>();
            CreateMap<ClientRequest, ClientLoginDto>();
            CreateMap<ClientLoginDto, ClientLoginResponse>();

            CreateMap<ClientClaim, ClientClaimDetail>();
            CreateMap<ClientClaimRequest, CreateClientClaim>();
            CreateMap<ClientClaimRequest, UpdateClientClaim>();

            CreateMap<ApiClaim, ApiClaimDetail>()
                .ForMember(x => x.RequiredIdToken, y => y.MapFrom(src => src.RequireIdToken));
            CreateMap<ApiClaim, ApiClaimForServiceDetail>();
            CreateMap<Service, ServiceDetail>();
        }
    }
}
