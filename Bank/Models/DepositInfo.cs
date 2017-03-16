namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepositInfo")]
    public partial class DepositInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepositInfo()
        {
            Deposit = new HashSet<Deposit>();
        }

        public int id { get; set; }

        public int currencyId { get; set; }

        public int percentDeposit { get; set; }

        public int limitMoney { get; set; }

        [Required]
        [StringLength(255)]
        public string descriptionDeposit { get; set; }

        public int maxTimeDeposit { get; set; }

        public virtual Currency Currency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deposit> Deposit { get; set; }
    }
}
