namespace BaobabRidgeRecordSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var result = FileManager.Load();
            MessageBox.Show($"Loaded: {result.Animals.Count}, Skipped: {result.Skipped}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAnimalDetails_Click(object sender, EventArgs e)
        {

        }

        private void lblAnimalID_Click(object sender, EventArgs e)
        {

        }
    }
}
