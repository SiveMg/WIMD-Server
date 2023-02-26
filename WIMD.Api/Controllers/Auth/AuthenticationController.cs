using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using WIMD.Application.Users.Auth.Login;
using WIMD.Application.Users.Auth.Register;

namespace WIMD.Api.Controllers.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthenticationController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginCommand userLoginModel)
        {
            var loginResult = await _mediator.Send(userLoginModel);
            if (loginResult.Token != null)
            {
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(loginResult.Token),
                    expiration = loginResult?.Token?.ValidTo
                });
            }
            return Unauthorized();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationCommand userRegistrationModel)
        {
            var registrationResult = await _mediator.Send(userRegistrationModel);
            return StatusCode(StatusCodes.Status500InternalServerError, registrationResult);
        }
    }
}
