using WIMD.Application.Configuration.Commands;

namespace WIMD.Application.Users.Auth.Register
{
    public class UserRegistrationCommand : CommandBase<Guid>
    {
        public string UserName { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Password { get; }

        public UserRegistrationCommand(string userName, string firstName, string lastName, string email, string password)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
    }
}
