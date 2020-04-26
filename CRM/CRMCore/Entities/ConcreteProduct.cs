namespace CRMCore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConcreteProduct
    {
        public Guid Id { get; set; }

        public Guid ProductTypeId { get; set; }

        public bool Sold { get; set; }

        public virtual ProductType ProductType { get; set; }

        public virtual Order Order { get; set; }
    }
}
