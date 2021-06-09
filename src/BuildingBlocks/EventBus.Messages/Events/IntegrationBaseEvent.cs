using System;

namespace EventBus.Messages.Events
{
    public abstract class IntegrationBaseEvent
    {
        public Guid Id { get; }
        public DateTime CreationDate { get; }

        protected IntegrationBaseEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        protected IntegrationBaseEvent(Guid id, DateTime createDate)
        {
            Id = id;
            CreationDate = createDate;
        }
    }
}
