namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommunityComment")]
    public partial class CommunityComment
    {
        public int Id { get; set; }

        public int CommunityId { get; set; }

        [Required]
        [StringLength(32)]
        public string Username { get; set; }

        [Required]
        [StringLength(16)]
        public string Password { get; set; }

        [Required]
        [StringLength(512)]
        public string Content { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
