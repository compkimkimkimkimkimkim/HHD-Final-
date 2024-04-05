using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.Models
{
    public class CommunityCategory
    {
        public int Id { get; set; }
        public int CommunityId { get; set; }
        public int CategoryId { get; set; }
    }

    public class CommunityCategoryCustom : CommunityCategory
    {
        public string CategoryName { get; set; }
    }
}