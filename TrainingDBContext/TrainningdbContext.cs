using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2;

public class TrainingDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=model;User Id=SA;Password=reallyStrongPwd123;Encrypt=False;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
        
    }
    public DbSet<userClass> Users { get; set; }

}