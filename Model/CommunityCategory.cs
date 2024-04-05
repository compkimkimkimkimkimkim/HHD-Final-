namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommunityCategory")]
    public partial class CommunityCategory
    {
        public int Id { get; set; }

        public int CommunityId { get; set; }

        public int CategoryId { get; set; }
    }
}
