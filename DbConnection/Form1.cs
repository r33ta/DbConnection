namespace DbConnection;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        GetAllComponents();
    }


    // Adds new computer to database
    private void AddPcBtn_Click(object sender, EventArgs e)
    {
        using (var ac = new ApplicationContext())
        {
            var computer = new Computers(
                NameBox.Text,
                ((Processors)ProcessorsBox.SelectedItem).Id,
                ((Videoadapters)VideoadaptersBox.SelectedItem).Id,
                ((Memory)MemoryBox.SelectedItem).Id
            );

            ac.Computers.Add(computer);
            ac.SaveChanges();
        }
        GetComputers();
    }


    private void GetAllComponents()
    {
        GetComputers();
        GetProcessors();
        GetVideoadapters();
        GetMemory();
    }


    // Gets computers from the database
    private void GetComputers()
    {
        using (var ac = new ApplicationContext())
        {
            var computers = ac.Computers.ToArray();
            list.Items.Clear();
            list.Items.AddRange(computers);
        }
    }


    // Gets processors from the database
    private void GetProcessors()
    {
        using (var ac = new ApplicationContext())
        {
            var processors = ac.Processors.ToArray();
            ProcessorsBox.Items.Clear();
            ProcessorsBox.Items.AddRange(processors);
        }
    }


    // Gets videoadapters from the database
    private void GetVideoadapters()
    {
        using (var ac = new ApplicationContext())
        {
            var videoadapters = ac.Videoadapters.ToArray();
            VideoadaptersBox.Items.Clear();
            VideoadaptersBox.Items.AddRange(videoadapters);
        }
    }


    // Gets memory from the database
    private void GetMemory()
    {
        using (var ac = new ApplicationContext())
        {
            var memory = ac.Memory.ToArray();
            MemoryBox.Items.Clear();
            MemoryBox.Items.AddRange(memory);
        }
    }


    // Puts in fields all PC components by clicking on one of them
    private void list_SelectedIndexChanged(object sender, EventArgs e)
    {
        Computers? computer = list.SelectedItem as Computers;

        NameBox.Text = computer?.Name;

        // Looking for processor by id
        for (int i = 0; i < ProcessorsBox.Items.Count; ++i)
            if (((Processors)ProcessorsBox.Items[i]).Id == computer?.ProcessorId)
                ProcessorsBox.SelectedIndex = i;

        // Looking for videoadapter by id
        for (int i = 0; i < VideoadaptersBox.Items.Count; ++i)
            if (((Videoadapters)VideoadaptersBox.Items[i]).Id == computer?.VideoadapterId)
                VideoadaptersBox.SelectedIndex = i;

        // Looking for memory by id
        for (int i = 0; i < MemoryBox.Items.Count; ++i)
            if (((Memory)MemoryBox.Items[i]).Id == computer?.MemoryId)
                MemoryBox.SelectedIndex = i;
    }
}