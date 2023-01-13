using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnection;

[Table("Memory")]
[PrimaryKey("Id")]
public class Memory
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("memory_size")]
    public int MemorySize { get; set; }

    public override string ToString() => $"{Name}, {MemorySize}GB";
}
