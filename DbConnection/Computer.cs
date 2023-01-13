using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnection;

[Table("Computers")]
[PrimaryKey("Id")]
public class Computer
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("processor_id")]
    public int ProcessorId { get; set; }

    [Column("videoadapter_id")]
    public int VideoadapterId { get; set; }

    [Column("memory_id")]
    public int MemoryId { get; set; }

    public override string ToString() => $"{Name}";
}
