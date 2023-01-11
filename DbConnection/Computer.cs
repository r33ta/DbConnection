using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnection;

[Table("Computers")]
[PrimaryKey("Id")]
public class Computer
{
    [Column("id")]
    public int Id;

    [Column("name")]
    public string? Name;

    [Column("processor_id")]
    public int ProcessorId;

    [Column("videoadapter_id")]
    public int VideoadapterId;

    [Column("memory_id")]
    public int MemoryId;

    public override string ToString() => $"{Name}";
}
