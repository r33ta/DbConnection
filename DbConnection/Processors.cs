namespace DbConnection;

public class Processors
{
    public Processors(string? name, double frequency, int cores)
    {
        Name = name;
        Frequency = frequency;
        Cores = cores;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public double Frequency { get; set; }
    public int Cores { get; set; }

    public override string ToString() => $"{Name} {Cores}*{Frequency}GHz";
}
