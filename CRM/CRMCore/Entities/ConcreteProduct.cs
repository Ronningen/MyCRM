namespace CRMCore.Entities
{
    using System;

    public partial class ConcreteProduct
    {
        public Guid Id { get; set; }

        public Guid ProductTypeId { get; set; }

        public bool Sold { get; set; }

        public virtual ProductType ProductType { get; set; }

        public virtual Order Order { get; set; }
    }
}
