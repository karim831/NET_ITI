using Microsoft.EntityFrameworkCore;

namespace project.Models{
    public class StoreContext : DbContext{
    
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Pruchase> Pruchases { get; set; }

        public StoreContext(){}

        public StoreContext(DbContextOptions<StoreContext> options): base(options){}


        protected override void OnConfiguring(DbContextOptionsBuilder options){
            options.UseSqlServer("Server=./;Database=Store;Trusted_Connection=False;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(8,3);
        }

    }
}