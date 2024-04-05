namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LevelMary")]
    public partial class LevelMary: DbBase<LevelMary>
    {
        public string name { get; set; }

        [StringLength(1000)]
        public string filePath { get; set; }

        public int? type { get; set; }

        public int Id { get; set; }
    }
}
