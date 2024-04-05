namespace HHD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EventList : DbBase<EventList>
    {
        public int id { get; set; }

        [StringLength(1000)]
        public string EventPoster { get; set; }

        public int? EventType { get; set; }
    }
}
