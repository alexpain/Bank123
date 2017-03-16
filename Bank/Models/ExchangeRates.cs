namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExchangeRates
    {
        public int id { get; set; }

        public int currencyId { get; set; }

        public int currencyTransactionsId { get; set; }

        public double cost { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateRates { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual CurrencyTransactions CurrencyTransactions { get; set; }
    }
}
