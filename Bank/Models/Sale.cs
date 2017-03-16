namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sale")]
    public partial class Sale
    {
        public int id { get; set; }

        public int discount { get; set; }

        public int statusId { get; set; }

        public int servicesId { get; set; }

        public virtual StatusClient StatusClient { get; set; }

        public virtual TypeServices TypeServices { get; set; }
    }
}
