using WIMD.Domain.SeedWork;

namespace WIMD.Domain.Users.Rules
{
    public class UserNameMustBeUniqueRule : IBusinessRule
    {
        //public string Message => throw new NotImplementedException();
        private readonly string _userName;
        private readonly IUserRepository userRepository;
        public UserNameMustBeUniqueRule(string userName)
        {
            this._userName = userName;
        }
        public bool IsBroken()
        {
            throw new NotImplementedException();
        }
    }
}
