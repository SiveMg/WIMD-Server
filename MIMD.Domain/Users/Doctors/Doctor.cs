using WIMD.Domain.SeedWork;
using WIMD.Domain.Users.Doctors;

namespace WIMD.Domain.Users
{
    public class Doctor : Entity
    {
        public DoctorId DoctorId { get; set; }
        public UserId UserId { get; set; }

        //TODO: Add doctor details
    }
}
