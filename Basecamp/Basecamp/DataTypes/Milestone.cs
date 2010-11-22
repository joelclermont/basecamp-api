using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class Milestone
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public bool Completed { get; set; }
        public int ProjectID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatorID { get; set; }
        public string CreatorName { get; set; }
        public int ResponsiblePartyID { get; set; }
        public string ResponsiblePartyType { get; set; }
        public string ResponsiblePartyName { get; set; }
        public int CommentsCount { get; set; }
        public DateTime CompletedOn { get; set; }
        public int CompleterID { get; set; }
        public string CompleterName { get; set; }
    }
}
