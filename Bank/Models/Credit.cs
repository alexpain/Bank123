namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Credit")]
    public partial class Credit
    {
        public int id { get; set; }

        public int clientId { get; set; }

        public int creditInfoId { get; set; }

        public int creditTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateCredit { get; set; }

        public int transactionId { get; set; }

        public int amountCredit { get; set; }

        public virtual Client Client { get; set; }

        public virtual CreditInfo CreditInfo { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
