using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.Models
{
	public class UoN
	{
        public int id { get; set; }
        public string Images { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int UoNType { get; set; }
    }
}