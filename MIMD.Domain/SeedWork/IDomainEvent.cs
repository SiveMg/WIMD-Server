using MediatR;

namespace WIMD.Domain.SeedWork
{
    public interface IDomainEvent : INotification
    {
        DateTime OccuredOn { get; }
    }
}
