using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.Models
{
	public class LocalTion
	{
        public int Id { get; set; }
        public string LocaltionName { get; set; }
        public string LocaltionAddress { get; set; }
        public int LocaltionType { get; set; }
        public string LineColour { get; set; }
        public decimal Distance { get; set; }
        public int Minutes { get; set; }
        public string BusNumbers { get; set; }
        public string Images { get; set; }
	}
}