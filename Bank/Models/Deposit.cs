namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deposit")]
    public partial class Deposit
    {
        public int id { get; set; }

        public int depositInfoId { get; set; }

        [Column(TypeName = "date")]
        public DateTime startDateDeposit { get; set; }

        [Column(TypeName = "date")]
        public DateTime endDateDeposit { get; set; }

        public int clientId { get; set; }

        public int transactionId { get; set; }

        public int amountDeposit { get; set; }

        public virtual Client Client { get; set; }

        public virtual DepositInfo DepositInfo { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
