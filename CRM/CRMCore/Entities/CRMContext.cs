namespace CRMCore.Entities
{
    using System.Data.Entity;

    public partial class CRMContext : DbContext
    {
        public CRMContext() : base("name=CRMContext")
        {

        }

        public virtual DbSet<ConcreteProduct> ConcreteProducts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductType>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("UserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));
        }
    }
}
