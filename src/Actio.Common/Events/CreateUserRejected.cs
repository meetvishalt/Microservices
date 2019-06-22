using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Events
{
    public class CreateUserRejected : IRejectedEvent
    {
        public string Reason { get; }
        
        public string Code { get; }

        public string Email { get; set; }

        protected CreateUserRejected()
        {

        }

        public CreateUserRejected(string email, string reason, string code)
        {
            Reason = reason;
            Email = email;
            Code = code;
        }
    }
}
