using AutoMapper;
using QuestionBank.Api.Contracts.Subscription;
using QuestionBank.Application.Commands.ClientClaims;
using QuestionBank.Application.Commands.Roles;
using QuestionBank.Application.Commands.Users;
using QuestionBank.Application.Helpers.Dtos;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Api.MappingProfiles
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<Role, RoleDetail>();
            CreateMap<RoleClaim, RoleClaimDetail>();
            CreateMap<RoleRequest, CreateRole>();
            CreateMap<RoleRequest, UpdateRole>();
            CreateMap<UserRequest, CreateUser>();
            CreateMap<CompanyRequest, CreateUser>();
            CreateMap<UpdateUserRequest, UpdateUser>();
            CreateMap<ChangePasswordRequest, ChangePassword>();
            CreateMap<ResetPasswordRequest, ResetPassword>();
            CreateMap<ForgotPasswordRequest, ConfirmForgotPassword>();
            CreateMap<IdentityUser, UserDetail>()
                .ForMember(x=>x.Roles, y=>y.MapFrom(src=>src.IdentityUserRoles));
            CreateMap<UserLoginDto, UserLoginResponse>();
            CreateMap<RoleDto, RoleResponse>();
            CreateMap<ClientClaim, ClientClaimDto>();
            CreateMap<ClientClaimRequest, CreateClientClaim>();
            CreateMap<ClientClaimRequest, CreateClientClaim>();
            CreateMap<ActivateDeactivateUserRequest, ActivateUser>();
            CreateMap<IdentityUserRole, UserRoleDetail>();
            CreateMap<Organization, OrganizationDetailDto>();
            CreateMap<Organization, OrganizationDto>();
            CreateMap<Subscription, SubscriptionDetailDto>();
        }
    }
}
