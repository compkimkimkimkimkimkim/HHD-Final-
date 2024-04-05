namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TitleImage")]
    public partial class TitleImage
    {
        public int id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Image { get; set; }

        [Required]
        [StringLength(255)]
        public string PageName { get; set; }
    }
}
