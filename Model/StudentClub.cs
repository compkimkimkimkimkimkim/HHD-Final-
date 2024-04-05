namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentClub")]
    public partial class StudentClub:DbBase<StudentClub>
    {
        public int id { get; set; }

        [StringLength(1000)]
        public string Images { get; set; }

        [StringLength(1000)]
        public string Name { get; set; }

        public string Content { get; set; }

        [StringLength(1000)]
        public string Link { get; set; }

        public int? StudentClubType { get; set; }
    }
}
