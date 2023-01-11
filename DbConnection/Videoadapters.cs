using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnection;

[Table("Videoadapters")]
[PrimaryKey("Id")]
public class Videoadapters
{
    [Column("id")]
    public int Id;

    [Column("name")]
    public string? Name;
    
    [Column("memory_size")]
    public int MemorySize;

    [Column("frequency")]
    public double Frequency;

    public override string ToString() => $"{Name}, {MemorySize}GB";
}
