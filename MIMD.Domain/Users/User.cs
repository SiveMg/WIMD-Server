using WIMD.Domain.SeedWork;

namespace WIMD.Domain.Users
{
    public class User : Entity
    {
        public UserId UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
