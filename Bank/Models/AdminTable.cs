namespace Bank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminTable")]
    public partial class AdminTable
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string loginAdmin { get; set; }

        [Required]
        [StringLength(30)]
        public string passwordAdmin { get; set; }

        public int accessStatusId { get; set; }

        public virtual AccessStatus AccessStatus { get; set; }
    }
}
