namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Community")]
    public partial class Community: DbBase<Community>
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(16)]
        public string Password { get; set; }

        [Required]
        [StringLength(512)]
        public string Title { get; set; }

        public int CategoryId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
