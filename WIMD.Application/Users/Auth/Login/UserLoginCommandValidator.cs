using FluentValidation;

namespace WIMD.Application.Users.Auth.Login
{
    public class UserLoginCommandValidator : AbstractValidator<UserLoginCommand>
    {
        public UserLoginCommandValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName cannot be empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty");
        }
    }
}
