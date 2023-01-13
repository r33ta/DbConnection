namespace DbConnection;

public class Computers
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int ProcessorId { get; set; }
    public int VideoadapterId { get; set; }
    public int MemoryId { get; set; }

    public override string ToString() => $"{Name}";
}
