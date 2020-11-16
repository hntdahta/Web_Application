using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Application.Models

{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public int Rate { get; set; }
        public int Viewed { get; set; }
        public string CreatedDate { get; set; }
        public Category Category { get; set; }
    }
}
