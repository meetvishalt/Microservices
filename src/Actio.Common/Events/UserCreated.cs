using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Events
{
    public class UserCreated : IEvent
    {
        public string Email { get; }

        public string Name { get; }


        protected UserCreated()
        {

        }

        public UserCreated(string Email, string Name)
        {
            this.Email = Email;
            this.Name = Name;

        }
    }
}
