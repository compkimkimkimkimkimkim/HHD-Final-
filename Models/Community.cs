using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHD.Models
{
    public class Community
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
    }

    public class CommunityCustom : Community
    {
        public int CollectionCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public List<CommunityPicture> Pictures { get; set; } = new List<CommunityPicture>();
        public List<CommunityCategoryCustom> Categories { get; set; } = new List<CommunityCategoryCustom>();
        public List<CommunityComment> Comments { get; set; } = new List<CommunityComment>();
    }
}