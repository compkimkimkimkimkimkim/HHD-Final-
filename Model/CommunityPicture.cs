namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommunityPicture")]
    public partial class CommunityPicture
    {
        public int Id { get; set; }

        public int CommunityId { get; set; }

        [Required]
        [StringLength(512)]
        public string Path { get; set; }
    }
}
