namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditInfo")]
    public partial class CreditInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CreditInfo()
        {
            Credit = new HashSet<Credit>();
        }

        public int id { get; set; }

        public int maxCost { get; set; }

        public int currencyId { get; set; }

        public int percentCredit { get; set; }

        public int maxTimeCredit { get; set; }

        [Required]
        [StringLength(255)]
        public string descriptionCredit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Credit> Credit { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
