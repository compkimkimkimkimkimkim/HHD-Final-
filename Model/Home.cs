using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace HHD.Model
{
    [Table("Home")]
    public partial class Home : DbBase<Home>
    {
        [Key]
        public int IdHome { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string category { get; set; }

        public string Link { get; set; }

        public string Content { get; set; }

        public int? Rank { get; set; }
    }
}
