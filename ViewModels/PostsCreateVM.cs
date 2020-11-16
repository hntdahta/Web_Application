using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Application.Models;

namespace Web_Application.ViewModels
{
    public class PostsCreateVM
    {

        public Blog Blog { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }

    }
}
