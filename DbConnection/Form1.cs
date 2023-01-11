namespace DbConnection;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        GetComponents();
    }

    private void GetComponents()
    {
        GetComputers();
        GetProcessors();
        GetVideoadapters();
        GetMemory();
    }

    private void GetComputers()
    {
        using (var ac = new ApplicationContext())
        {
            var computers = ac.Computers.ToArray();
            
            list.Items.Clear();
            list.Items.AddRange(computers);
        }
    }
    private void GetProcessors()
    {
        using (var ac = new ApplicationContext())
        {
            var processors = ac.Processors.ToArray();

            ProcessorsBox.Items.Clear();
            ProcessorsBox.Items.AddRange(processors);
        }
    }
    private void GetVideoadapters()
    {
        using (var ac = new ApplicationContext())
        {
            var videoadapters = ac.Videoadapters.ToArray();

            VideoadaptersBox.Items.Clear();
            VideoadaptersBox.Items.AddRange(videoadapters);
        }
    }
    private void GetMemory()
    {
        using (var ac = new ApplicationContext())
        {
            var memory = ac.Memory.ToArray();

            MemoryBox.Items.Clear();
            MemoryBox.Items.AddRange(memory);
        }
    }
}