﻿using System.Text.Json.Serialization;
using WIMD.Domain.SeedWork;

namespace WIMD.Application.Configuration.DomainEvents
{
    public class DomainNotificationBase<T> : IDomainEventNotification<T> where T : IDomainEvent
    {
        [JsonIgnore]
        public T DomainEvent { get; }

        public Guid Id { get; }

        public DomainNotificationBase(T domainEvent)
        {
            this.Id = Guid.NewGuid();
            this.DomainEvent = domainEvent;
        }
    }
}
