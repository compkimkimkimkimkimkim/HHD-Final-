using System;
using System.Web;

namespace HHD.Models
{
    public class Home 
    {
        public int IdHome { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int category { get; set; }
        public string Link { get; set; }
        public string Content { get; set; }
        public int Rank { get; set; }

    }
}
