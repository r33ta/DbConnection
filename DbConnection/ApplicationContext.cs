using Microsoft.EntityFrameworkCore;

namespace DbConnection;

public class ApplicationContext : DbContext
{
    public DbSet<Computer> Computers { get; set; } = null!;
    public DbSet<Processors> Processors { get; set; } = null!;
    public DbSet<Videoadapters> Videoadapters { get; set; } = null!;
    public DbSet<Memory> Memory { get; set; } = null!;

    private readonly string Connection = 
        "Server=192.168.88.30;Database=Components;User Id=root;Password=root;trustServerCertificate=true";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Connection);
    }
}
