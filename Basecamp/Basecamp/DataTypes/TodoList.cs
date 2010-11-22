using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class TodoList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectID { get; set; }
        public int MilestoneID { get; set; }
        public int Position { get; set; }
        public bool Private { get; set; }
        public bool Tracked { get; set; }
        public List<TodoItem> TodoItems { get; set; }
    }
}
