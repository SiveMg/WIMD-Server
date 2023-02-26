using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WIMD.Application.Configuration.Commands;
using WIMD.Domain.Users;

namespace WIMD.Application.Users.Auth.Login
{
    public class UserLoginHandler : ICommandHandler<UserLoginCommand, UserLoginDto>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public UserLoginHandler(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            this._userManager = userManager;
            this._configuration = configuration;
        }
        public async Task<UserLoginDto> Handle(UserLoginCommand request, CancellationToken cancellationToken)
        {
            var existingUser = await this._userManager.FindByNameAsync(request.UserName);
            if (existingUser != null && await _userManager.CheckPasswordAsync(existingUser, request.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(existingUser);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, existingUser.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var role in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }
                var token = GetToken(authClaims);
                return new UserLoginDto { Token = token };
            }
            return new UserLoginDto { Token = null };
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: this._configuration["JWT:ValidIssuer"],
                audience: this._configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }
}
