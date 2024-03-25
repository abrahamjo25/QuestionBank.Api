using QuestionBank.Application.Helpers.Dtos;
using QuestionBank.Application.Helpers.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Web.Mvc;

namespace QuestionBank.Application.Services
{
    public interface ITokenhandler
    {
        Task<SecurityToken> CreateSecurityToken(List<Claim> claims, int accessTokenLifetime);
        Task<string> WriteToken(SecurityToken token);
        Task<bool> ValidateToken(string claim, List<Claim> claims);
        Task<bool> ValidateToken(string token);
        Task<List<Claim>> GetClaims(string token);
        Task<JwtSecurityToken> GetTokenDescriptor(List<Claim> claims, int accessTokenLifetime);
        Task<string> GenerateRefreshToken();
        Task<List<Claim>> GetClaimFromRole(List<RoleDto> roles);
        Task<string> GetJwtString(int tokenLife, List<Claim> claimList);
    }
    public class TokenHandlerService : ITokenhandler
    {
        private readonly JwtSettings _jwtSettings;
        private readonly byte[] _key;
        public TokenHandlerService(IOptions<JwtSettings> jwtOptions)
        {
            _jwtSettings = jwtOptions.Value;
            _key = Encoding.ASCII.GetBytes(_jwtSettings.SigningKey);
        }
        public JwtSecurityTokenHandler TokenHandler = new JwtSecurityTokenHandler();
        public async Task<SecurityToken> CreateSecurityToken(List<Claim> claims, int accessTokenLifetime)
        {
            var tokenDescriptor = GetTokenDescriptor(claims, accessTokenLifetime);

            return await tokenDescriptor;
        }
        public async Task<string> WriteToken(SecurityToken token)
        {
            return TokenHandler.WriteToken(token);
        }
        public async Task<bool> ValidateToken(string claim, List<Claim> claims) => claims.Where(x => x.Value.ToLower() == claim.ToLower()).Any();
        public async Task<bool> ValidateToken(string token)
        {
            SecurityToken securityToken = null;
            var validations = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(_key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
            try
            {
                TokenHandler.ValidateToken(token, validations, out securityToken);
            }
            catch (Exception e)
            {
                return false;
            }
            if (securityToken.ValidTo != DateTime.MinValue && securityToken.ValidTo > DateTime.UtcNow)
                return true;
            return false;
        }
        public async Task<List<Claim>> GetClaims(string token)
        {
            var claims = new List<Claim>();
            try
            {
                var securityToken = TokenHandler.ReadJwtToken(token);
                claims = securityToken.Claims.ToList();
            }
            catch (Exception e)
            {
                claims = new List<Claim>();
            }

            return claims;
        }
        public async Task<JwtSecurityToken> GetTokenDescriptor(List<Claim> claims, int accessTokenLifetime)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(_key);
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: "ICS",
                claims: claims,
                expires: DateTime.Now.AddMinutes(accessTokenLifetime),
                signingCredentials: signingCredentials
                );
            return jwtSecurityToken;
        }
        public async Task<string> GenerateRefreshToken()
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 50)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public async Task<List<Claim>> GetClaimFromRole(List<RoleDto> roles)
        {
            var result = new List<Claim>();
            foreach (var role in roles)
            {
                foreach (var clientClaim in role.Claims)
                {
                    Claim claim = new Claim(clientClaim.Id.ToString(), clientClaim.Claim);
                    result.Add(claim);
                }
            }
            return result;
        }
        public async Task<string> GetJwtString(int tokenLife, List<Claim> claimList)
        {
            var claims = new[]
                {
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
             }
                .Union(claimList).ToList();
            var token = await CreateSecurityToken(claims, tokenLife);
            return await WriteToken(token);
        }
    }
}
