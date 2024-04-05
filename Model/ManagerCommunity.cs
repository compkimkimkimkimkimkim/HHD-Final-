namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManagerCommunity")]
    public partial class ManagerCommunity: DbBase<ManagerCommunity>
    {
        public int id { get; set; }

        [StringLength(3000)]
        public string Title { get; set; }

        [StringLength(4000)]
        public string Content { get; set; }

        public int? ManagerCommunityType { get; set; }
    }
}
