using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Application.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int AnimeID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescriptions { get; set; }
    }
}
