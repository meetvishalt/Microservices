using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Events
{
    public class CreateActivityRejected : IRejectedEvent
    {
        public string Reason { get; }

        public string Code { get; }

        public string Category { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        protected CreateActivityRejected()
        {

        }

        public CreateActivityRejected(string category, string name, string description, 
            string reason, string code)
        {
            Reason = reason;
            Category = category;
            Name = name;
            Description = description;
            Code = code;
        }
    }
}
