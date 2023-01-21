using WIMD.Domain.SeedWork;
using WIMD.Domain.Users.Patients;

namespace WIMD.Domain.Users
{
    public class Patient : Entity
    {
        public PatientId PatientId { get; set; }
        public UserId UserId { get; set; }
        
        // TODO: Add patient information.
    }
}
