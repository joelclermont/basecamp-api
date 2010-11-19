using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProjectID { get; set; }
        public int ElementsCount { get; set; }
        public string Type { get; set; }
    }
}
