using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AccountHolderID { get; set; }
        public bool SSLEnabled { get; set; }
        public bool EmailNotificationEnabled { get; set; }
        public bool TimeTrackingEnabled { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Subscription Subscription { get; set; }
        public List<string> DefaultAttachmentCategories { get; set; }
        public List<string> DefaultPostCategories { get; set; }
    }
}
