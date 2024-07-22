using Microsoft.EntityFrameworkCore;


namespace efcode_first.models;

public class MoolContext : DbContext{
    
    public MoolContext(){}

    public MoolContext(DbContextOptions<MoolContext> options):base(options){}

    public virtual DbSet<User> Users{get;set;}

    public virtual DbSet<Order> Orders{get;set;}

    public virtual DbSet<Item> Items{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder option){
        option.UseSqlServer("Server=./;Database=mool;Trusted_Connection=False;TrustServerCertificate=True");
    }


}