namespace DbConnection;

public class Memory
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int MemorySize { get; set; }

    public override string ToString() => $"{Name}, {MemorySize}GB";
}
