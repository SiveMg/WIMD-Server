using System.IdentityModel.Tokens.Jwt;

namespace WIMD.Application.Users.Auth.Login
{
    public class UserLoginDto
    {
        public JwtSecurityToken? Token { get; set; }
    }
}
