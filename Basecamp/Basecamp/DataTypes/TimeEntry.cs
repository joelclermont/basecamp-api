using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class TimeEntry
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public int PersonID { get; set; }
        public DateTime Date { get; set; }
        public string Hours { get; set; }
        public string Description { get; set; }
        public int TodoItemID { get; set; }
    }
}
