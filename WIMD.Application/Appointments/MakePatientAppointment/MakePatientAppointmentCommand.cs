using WIMD.Application.Configuration.Commands;

namespace WIMD.Application.Appointments.MakePatientAppointment
{
    public class MakePatientAppointmentCommand : CommandBase<Guid>
    {
        public Guid PatientId { get; }
        public Guid DoctorId { get; }
        public DateTime TimeFrom { get; }
        public DateTime TimeTo { get; }

        public MakePatientAppointmentCommand(
            Guid PatientId,
            Guid DoctorId,
            DateTime TimeFrom,
            DateTime TimeTo
            )
        {
            this.PatientId = PatientId;
            this.DoctorId = DoctorId;
            this.TimeFrom = TimeFrom;
            this.TimeTo = TimeTo;
        }
    }
}
