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
        public string Body { get; set; }
        public string DisplayBody { get; set; }
        public DateTime PostedOn { get; set; }
        public int ProjectID { get; set; }
        public int CategoryID { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public int MilestoneID { get; set; }
        public int CommentsCount { get; set; }
        public bool UseTextile { get; set; }
        public string ExtendedBody { get; set; }
        public string DisplayExtendedBody { get; set; }
        public int AttachmentsCount { get; set; }
        public List<Attachment> Attachments { get; set; }
        public bool Private { get; set; }
    }
}
