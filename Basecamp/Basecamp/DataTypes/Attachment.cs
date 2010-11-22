using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class Attachment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ByteSize { get; set; }
        public string DownloadURL { get; set; }
        public int ProjectID { get; set; }
        public int CategoryID { get; set; }
        public int PropertyID { get; set; }
        public bool Private { get; set; }
        public DateTime CreatedOn { get; set; }
        public int OwnerID { get; set; }
        public string OwnerType { get; set; }
        public int Collection { get; set; }
        public int Version { get; set; }
        public bool Current { get; set; }
    }
}
