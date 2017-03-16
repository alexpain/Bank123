namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractClient")]
    public partial class ContractClient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractClient()
        {
            CreditCard = new HashSet<CreditCard>();
        }

        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime startDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime endDate { get; set; }

        public int clientId { get; set; }

        public int balance { get; set; }

        public virtual Client Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditCard> CreditCard { get; set; }
    }
}
