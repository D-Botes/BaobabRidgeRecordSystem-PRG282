namespace BaobabRidgeRecordSystem
{
    public partial class MainForm : Form
    {
        // List used to store the animals
        private List<Animal> animals = new List<Animal>();
        public MainForm()
        {
            InitializeComponent();


        }

        // Reloads animals from the file and then redisplays them inside the grid
        private int RefreshGrid()
        {
            // Load the file and store it, and store amount skipped
            var result = FileManager.Load();
            int skipped = result.Skipped;

            // Clean the grid and fill in the animals list
            dgvAnimals.DataSource = null;
            animals = result.Animals;

            // Set the data source to animals, and fix headers
            dgvAnimals.DataSource = animals;
            dgvAnimals.Columns["AnimalId"].HeaderText = "Animal ID";
            dgvAnimals.Columns["RecoveryScore"].HeaderText = "Recovery Score";
            dgvAnimals.Columns["HousingUnit"].HeaderText = "Housing Unit";


            return skipped;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Display the data and store the amount skipped
            int skipped = RefreshGrid();

            // Display how many lines were skipped
            if (skipped > 0)
            {
                MessageBox.Show($"{skipped} line(s) in animals.txt were invalid and were skipped");
            }
        }
    }
}
