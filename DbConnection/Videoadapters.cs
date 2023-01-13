namespace DbConnection;

public class Videoadapters
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int MemorySize { get; set; }
    public double Frequency { get; set; }

    public override string ToString() => $"{Name}, {MemorySize}GB";
}
