using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.Models
{
    public class CommunityPicture
    {
        public int Id { get; set; }
        public int CommunityId { get; set; }
        public string Path { get; set; }
    }
}