namespace WIMD.Domain.SeedWork
{
    public class DomainEventBase : IDomainEvent
    {
        public DomainEventBase()
        {
            this.OccuredOn = DateTime.Now;
        }
        public DateTime OccuredOn { get; }
    }
}
