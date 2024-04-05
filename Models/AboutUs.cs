using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.Models
{
	public class AboutUs
	{
        public int id { get; set; }
        public string Images { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public string Ambitions { get; set; }
        public int AboutUsType { get; set; }
    }
}