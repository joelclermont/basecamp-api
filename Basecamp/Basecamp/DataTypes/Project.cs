using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Status { get; set; }
        public DateTime LastChangedOn { get; set; }
        
        //opted to remove the nested company element
        //to be consistent with every other data type
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

        public string Announcement { get; set; }
        public string StartPage { get; set; }
        public bool ShowWhiteboards { get; set; }
        public bool ShowAnnouncement { get; set; }
    }
}
