namespace DbConnection;

public class Computers
{
    public Computers(string? name, int processorId, int videoadapterId, int memoryId)
    {
        Name = name;
        ProcessorId = processorId;
        VideoadapterId = videoadapterId;
        MemoryId = memoryId;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public int ProcessorId { get; set; }
    public int VideoadapterId { get; set; }
    public int MemoryId { get; set; }

    public override string ToString() => $"{Name}";
}
