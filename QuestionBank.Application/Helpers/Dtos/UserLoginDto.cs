using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.Application.Helpers.Dtos
{
    public class UserLoginDto
    {
        public UserLoginDto()
        {

        }
        public UserLoginDto(string userName, string email, string firstName, string lastName, bool isCompany, string companyCode)
        {
            Username = userName;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            IsCompany = isCompany;
            CompanyCode = companyCode;
            Roles = new List<RoleDto>();
            Organizations = new List<OrganizationDto>();

        }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool IsCompany { get; set; } 
        public string CompanyCode { get; set; }
        public string IdToken { get; set; }
        public string RefreshToken { get; set; }
        public long Id { get; set; }
        public List<RoleDto> Roles { get; set; }
        public List<OrganizationDto> Organizations { get; set; }

    }

    public class RoleDto
    {
        public RoleDto()
        {
            Claims = new List<ClientClaimDto>();
        }
        public string RoleName { get; set; }
        public List<ClientClaimDto> Claims { get; set; }
    }

    public class ClientClaimDto
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public string Claim { get; set; }
    }

    public class OrganizationDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string OrganizationCode { get; set; }
    }
}