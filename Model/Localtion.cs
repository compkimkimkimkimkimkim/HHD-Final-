namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Localtion")]
    public partial class Localtion : DbBase<Localtion>
    {
        public int id { get; set; }

        [StringLength(1000)]
        public string LocaltionName { get; set; }

        [StringLength(1000)]
        public string LocaltionAddress { get; set; }

        public int? LocaltionType { get; set; }

        [StringLength(1000)]
        public string LineColour { get; set; }

        public double? Distance { get; set; }

        public int? Minutes { get; set; }

        [StringLength(1000)]
        public string BusNumbers { get; set; }

        [StringLength(1000)]
        public string Images { get; set; }
    }
}
