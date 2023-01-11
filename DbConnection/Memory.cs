using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnection;

[Table("Memory")]
[PrimaryKey("Id")]
public class Memory
{
    [Column("id")]
    public int Id;

    [Column("name")]
    public string? Name;

    [Column("memory_size")]
    public int MemorySize;

    public override string ToString() => $"{Name}, {MemorySize}GB";
}
