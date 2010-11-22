using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basecamp.DataTypes
{
    class Comment
    {
        public int ID { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public int CommentableID { get; set; }
        public string CommentableType { get; set; }
        public string Body { get; set; }
        public string EmailedFrom { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AttachmentsCount { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
