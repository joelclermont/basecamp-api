using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime PostedOn { get; set; }
        public int AttachmentsCount { get; set; }
        public Category Category { get; set; }
    }
}
