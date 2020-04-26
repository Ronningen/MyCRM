namespace CRMCore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            ConcreteProducts = new HashSet<ConcreteProduct>();
        }

        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime OpenDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime CloseDate { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConcreteProduct> ConcreteProducts { get; set; }
    }
}
