using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace HHD.Model
{


    [Table("UoN")]
    public partial class UoN : DbBase<UoN>
    {
        public int id { get; set; }

        [StringLength(1000)]
        public string Images { get; set; }

        [StringLength(1000)]
        public string Name { get; set; }

        public int? Rank { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        [StringLength(1000)]
        public string Title { get; set; }

        public int? UoNType { get; set; }
    }
}
