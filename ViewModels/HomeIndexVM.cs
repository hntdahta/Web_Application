using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Application.Models;

namespace Web_Application.ViewModels
{
    public class HomeIndexVM
    {
        public List<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
