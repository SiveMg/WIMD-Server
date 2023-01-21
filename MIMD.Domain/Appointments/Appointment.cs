using WIMD.Domain.SeedWork;
using WIMD.Domain.Users;
using WIMD.Domain.Users.Doctors;
using WIMD.Domain.Users.Patients;

namespace WIMD.Domain.Appointments
{
    public class Appointment : Entity, IAggregateRoot
    {
        public AppointmentId Id { get; set; }
        public PatientId PatientId { get; set; }
        public DoctorId Doctor { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public AppointmentStateId State { get; set; }

    }
}
