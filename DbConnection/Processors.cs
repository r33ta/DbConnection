using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnection;

[Table("Processors")]
[PrimaryKey("Id")]
public class Processors
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("frequency")]
    public double Frequency { get; set; }

    [Column("cores")]
    public int Cores { get; set; }

    public override string ToString() => $"{Name} {Cores}*{Frequency}GHz";
}
