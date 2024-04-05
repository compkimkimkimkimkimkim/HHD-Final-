using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.Models
{
    public class CommunityComment
    {
        public int Id { get; set; }
        public int CommunityId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
    }
}