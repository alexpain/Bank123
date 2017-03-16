namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditCard")]
    public partial class CreditCard
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string numberCard { get; set; }

        [Column(TypeName = "date")]
        public DateTime endDate { get; set; }

        public int cardInfoId { get; set; }

        public int contractId { get; set; }

        public int statusCreditCardId { get; set; }

        public virtual CardInfo CardInfo { get; set; }

        public virtual ContractClient ContractClient { get; set; }

        public virtual StatusCreditCard StatusCreditCard { get; set; }
    }
}
