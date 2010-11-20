using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class Subscription
    {
        public string Name { get; set; }
        public float Writeboards { get; set; }
        public int Projects { get; set; }
        public int Storage { get; set; }
        public bool SSL { get; set; }
        public bool TimeTracking { get; set; }
    }
}
