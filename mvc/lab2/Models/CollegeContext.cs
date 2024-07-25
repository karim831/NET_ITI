using Microsoft.EntityFrameworkCore;


namespace lab2.Models;
public class CollegeContext : DbContext{
    public DbSet<Student> Students{get; set;}
    
    public DbSet<Department> Departments{get; set;}

    public CollegeContext(){}

    public CollegeContext(DbContextOptions<CollegeContext> options): base(options){}


    protected override void OnConfiguring(DbContextOptionsBuilder options){
        options.UseSqlServer("Server=./;Database=College;Trusted_Connection=False;TrustServerCertificate=True");
    }
}

