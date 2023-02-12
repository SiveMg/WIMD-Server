using MediatR;
using Microsoft.Extensions.DependencyInjection;
using WIMD.Application.Configuration.DomainEvents;
using WIMD.Domain.SeedWork;
using WIMD.Infrastructure.Database;

namespace WIMD.Infrastructure.Processing
{
    public class DomainEventsDispatcher : IDomainEventsDispatcher
    {
        private readonly IMediator _mediator;
        private readonly IServiceCollection _provider;
        private readonly WIMDContext _wimdContext;

        public DomainEventsDispatcher(IMediator mediator, IServiceCollection provider, WIMDContext wimdContext)
        {
            _mediator = mediator;
            _provider = provider;
            _wimdContext = wimdContext;
        }

        public async Task DispatchEventsAsync()
        {
            var domainEntities = this._wimdContext.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any()).ToList();

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();

            var domainEventNotifications = new List<IDomainEventNotification<IDomainEvent>>();
            foreach(var domainEvent in domainEvents)
            {
                Type domainEventNotificationType = typeof(IDomainEventNotification<>);
                var domainNotificationWithGenericType = domainEventNotificationType.MakeGenericType(domainEvent.GetType());
                var domainNotification = _provider.FirstOrDefault(c => c.GetType() == domainNotificationWithGenericType).GetType();//GetService(domainNotificationWithGenericType);


                //TODO: Come back to this
                
            }
        }
    }
}
