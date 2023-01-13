using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnection;

[Table("Videoadapters")]
[PrimaryKey("Id")]
public class Videoadapters
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("memory_size")]
    public int MemorySize { get; set; }

    [Column("frequency")]
    public double Frequency { get; set; }

    public override string ToString() => $"{Name}, {MemorySize}GB";
}
