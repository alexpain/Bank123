namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payments
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime datePayments { get; set; }

        public int clientId { get; set; }

        public int transactionId { get; set; }

        public int paymentsInfoId { get; set; }

        public int amountPayments { get; set; }

        public virtual Client Client { get; set; }

        public virtual PaymentsInfo PaymentsInfo { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
