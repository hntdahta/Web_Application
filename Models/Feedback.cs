using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Application.Models

{
    public class Feedback
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
