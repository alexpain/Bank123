namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            ContractClient = new HashSet<ContractClient>();
            Credit = new HashSet<Credit>();
            Deposit = new HashSet<Deposit>();
            Payments = new HashSet<Payments>();
            Transaction = new HashSet<Transaction>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string fullName { get; set; }

        [Required]
        [StringLength(30)]
        public string passportNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime birthday { get; set; }

        [Required]
        [StringLength(30)]
        public string email { get; set; }

        [Required]
        [StringLength(30)]
        public string loginClient { get; set; }

        [Required]
        [StringLength(30)]
        public string passwordClient { get; set; }

        [Required]
        [StringLength(30)]
        public string phone { get; set; }

        public int statusClientId { get; set; }

        public int accessStatusId { get; set; }

        public virtual AccessStatus AccessStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractClient> ContractClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Credit> Credit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deposit> Deposit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }

        public virtual StatusClient StatusClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
