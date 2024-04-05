using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.Models
{
	public class StudentClub
	{
        public int id { get; set; }
        public string Images { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public int StudentClubType { get; set; }
    }
}