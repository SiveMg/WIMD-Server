using Microsoft.EntityFrameworkCore;
using WIMD.Domain.Appointments;
using WIMD.Domain.Users;

namespace WIMD.Infrastructure.Database
{
    public class WIMDContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentState> AppointmentStates { get; set; }

        public WIMDContext(DbContextOptions options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WIMDContext).Assembly);
        }
    }
}
