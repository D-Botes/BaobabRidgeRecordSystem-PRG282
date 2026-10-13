namespace BaobabRidgeRecordSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var result = FileManager.Load();
            MessageBox.Show($"Loaded: {result.Animals.Count}, Skipped: {result.Skipped}");
        }
    }
}
