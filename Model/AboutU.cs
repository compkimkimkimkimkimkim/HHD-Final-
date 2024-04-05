namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AboutU : DbBase<AboutU>
    {
        public int id { get; set; }

        [StringLength(1000)]
        public string Images { get; set; }

        [StringLength(1000)]
        public string Name { get; set; }

        public string Major { get; set; }

        public string Ambitions { get; set; }

        public int? AboutUsType { get; set; }
    }
}
