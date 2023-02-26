using WIMD.Application.Configuration.Commands;

namespace WIMD.Application.Users.Auth.Login
{
    public class UserLoginCommand : CommandBase<UserLoginDto>
    {
        public string UserName { get; } 
        public string Password { get; } 
        
        public UserLoginCommand(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
