using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid UserId { get; }

        public Guid Id { get; }

        public string Category { get; }

        public string Name { get; }
        public string Description { get; }

        public DateTime CreatedAt { get; }

        protected ActivityCreated()
        {

        }

        public ActivityCreated(Guid UserId, string Name, string Category)
        {
            this.UserId = UserId;

            this.Name = Name;

            this.Category = Category;
        }
    }
}
