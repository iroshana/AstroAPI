namespace Astro.BusinessEntities
{
    using global::BusinessEntities;
    using System.Data.Entity;
    public partial class AstroModel: DbContext
    {
        public AstroModel()
            : base("name=AstroEntities")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Outlet> Outles { get; set; }
        public virtual DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
