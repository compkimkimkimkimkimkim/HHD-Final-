namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommunityCollection")]
    public partial class CommunityCollection
    {
        public int Id { get; set; }

        public int CommunityId { get; set; }

        public int UserId { get; set; }
    }
}
