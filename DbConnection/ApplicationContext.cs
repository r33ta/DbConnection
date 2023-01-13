using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbConnection;

public class ApplicationContext : DbContext
{
    public DbSet<Computers> Computers { get; set; }
    public DbSet<Processors> Processors { get; set; }
    public DbSet<Videoadapters> Videoadapters { get; set; }
    public DbSet<Memory> Memory { get; set; }

    private readonly string Connection = 
        "Server=192.168.88.30;Database=Components;User Id=root;Password=root;trustServerCertificate=true";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Connection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Computers>(entity =>
        {
            entity.ToTable("Computers");
            entity.HasKey("Id");
            entity.Property("Id").HasColumnName("id");
            entity.Property("Name").HasColumnName("name");
            entity.Property("ProcessorId").HasColumnName("processor_id");
            entity.Property("VideoadapterId").HasColumnName("videoadapter_id");
            entity.Property("MemoryId").HasColumnName("memory_id");
        });

        modelBuilder.Entity<Processors>(entity =>
        {
            entity.ToTable("Processors");
            entity.HasKey("Id");
            entity.Property("Id").HasColumnName("id");
            entity.Property("Name").HasColumnName("name");
            entity.Property("Frequency").HasColumnName("frequency");
            entity.Property("Cores").HasColumnName("cores");
        });

        modelBuilder.Entity<Videoadapters>(entity =>
        {
            entity.ToTable("Videoadapters");
            entity.HasKey("Id");
            entity.Property("Id").HasColumnName("id");
            entity.Property("Name").HasColumnName("name");
            entity.Property("MemorySize").HasColumnName("memory_size");
            entity.Property("Frequency").HasColumnName("frequency");
        });

        modelBuilder.Entity<Memory>(entity =>
        {
            entity.ToTable("Memory");
            entity.HasKey("Id");
            entity.Property("Id").HasColumnName("id");
            entity.Property("Name").HasColumnName("name");
            entity.Property("MemorySize").HasColumnName("memory_size");
        });
    }
}
