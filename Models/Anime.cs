using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Application.Models
{
    public class Anime
    {
        public int AnimeID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
        public string MovieLink { get; set; }
        public int CategoryID { get; set; }
        public int Rate { get; set; }
        public int Viewed { get; set; }
        public DateTime CreatedDate { get; set; }
        public Category Category { get; set; }

    }
}
