using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Application.Models

{
    public class Category
    {
        public int CategoryID { get; set; }
        public string NameCategory { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DisplayOrder { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
