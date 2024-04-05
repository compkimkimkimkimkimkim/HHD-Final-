namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Orientation")]
    public partial class Orientation : DbBase<Orientation>
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

        public int? OrientationType { get; set; }
    }
}
