
using WIMD.Domain.SeedWork;

namespace WIMD.Domain.Users
{
    public class UserId : TypedIdValueBase
    {
        public UserId(Guid value)
            : base(value) 
        { 
        }
    }
}
