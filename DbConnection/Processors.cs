using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbConnection;

[Table("Processors")]
[PrimaryKey("Id")]
public class Processors
{
    [Column("id")]
    public int Id;

    [Column("name")]
    public string? Name;

    [Column("frequency")]
    public double Frequency;

    [Column("cores")]
    public int Cores;

    public override string ToString() => $"{Name} {Cores}*{Frequency}GHz";
}
