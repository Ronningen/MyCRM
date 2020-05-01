namespace CRMCore.Entities
{
    using System;

    public partial class ConcreteProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConcreteProduct()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public Guid ProductTypeId { get; set; }

        public bool Sold { get; set; }

        public Guid? OrderId { get; set; }

        public virtual Order Order { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
