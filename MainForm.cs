using System.Globalization;

namespace BaobabRidgeRecordSystem
{
    public partial class MainForm : Form
    {
        // List used to store the animals
        private List<Animal> animals = new List<Animal>();

        //string for search feature
        private string loadedId ="";
        public MainForm()
        {
            InitializeComponent();

            dgvAnimals.CellClick += dgvAnimals_CellClick;
            btnSearch.Click += btnSearch_Click;
            btnSave.Click += btnSave_Click;
            btnClear.Click += btnClear_Click;
            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnGenerate.Click += btnGenerate_Click;
        }
        //Update feature

        //Edit mode toggle
        private void SetEditMode(bool editing)
        {
            txtAnimalID.ReadOnly = editing;
            btnAdd.Enabled = !editing;
            btnSave.Enabled = editing;
        }

        //Load animal data to form
        private void LoadIntoForm(Animal animal)
        {
            txtAnimalID.Text = animal.AnimalId;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString(CultureInfo.InvariantCulture);
            txtScore.Text = animal.RecoveryScore.ToString(CultureInfo.InvariantCulture);

            loadedId = animal.AnimalId;
            SetEditMode(true);
        }

        // Returns to Add mode
        private void ClearForm()
        {
            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();
            txtSearch.Clear();

            loadedId = string.Empty;
            SetEditMode(false);
            dgvAnimals.ClearSelection();
            txtAnimalID.Focus();
        }

        // Search comparison
        private int FindAnimalIndex(string id)
        {
            return animals.FindIndex(a => string.Equals(a.AnimalId, id, StringComparison.OrdinalIgnoreCase));
        }

        private void SelectGridRow(string id)
        {
            foreach (DataGridViewRow row in dgvAnimals.Rows)
            {
                if (string.Equals(row.Cells["AnimalId"].Value?.ToString(), id, StringComparison.OrdinalIgnoreCase))
                {
                    dgvAnimals.ClearSelection();
                    row.Selected = true;
                    dgvAnimals.CurrentCell = row.Cells[0];
                    return;
                }
            }
        }

        private void ShowFieldError(string message, TextBox field)
        {
            MessageBox.Show(message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            field.Focus();
            field.SelectAll();
        }

        // Update feature

        // Click a grid row to load it
        private void dgvAnimals_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string id = dgvAnimals.Rows[e.RowIndex].Cells["AnimalId"].Value?.ToString() ?? string.Empty;
            int index = FindAnimalIndex(id);

            if (index >= 0)
            {
                LoadIntoForm(animals[index]);
            }
        }

        //Search Operation
        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string id = txtSearch.Text.Trim();

            if (id.Length == 0)
            {
                MessageBox.Show("Please enter an Animal ID to search for.", "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }

            int index = FindAnimalIndex(id);

            if (index < 0)
            {
                MessageBox.Show($"No animal with ID \"{id}\" was found.", "Not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }

            LoadIntoForm(animals[index]);
            SelectGridRow(animals[index].AnimalId);
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }
        //Save feature
        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (loadedId.Length == 0)
            {
                MessageBox.Show("Load an animal first (click a row or search by ID).", "Save Changes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = FindAnimalIndex(loadedId);
            if (index < 0)
            {
                MessageBox.Show("That animal is no longer in the file.", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshGrid();
                ClearForm();
                return;
            }

            // Validator methods
            if (!Validator.ValidateName(txtName.Text, out string name, out string error))
            {
                ShowFieldError(error, txtName);
                return;
            }
            if (!Validator.ValidateSpecies(txtSpecies.Text, out string species, out error))
            {
                ShowFieldError(error, txtSpecies);
                return;
            }
            if (!Validator.ValidateAge(txtAge.Text, out string ageText, out error))
            {
                ShowFieldError(error, txtAge);
                return;
            }
            if (!Validator.ValidateRecoveryScore(txtScore.Text, out string scoreText, out error))
            {
                ShowFieldError(error, txtScore);
                return;
            }

            int age = int.Parse(ageText, CultureInfo.InvariantCulture);
            int score = int.Parse(scoreText, CultureInfo.InvariantCulture);

            // Keep old values so we can roll back if the file write fails
            Animal animal = animals[index];
            string oldName = animal.Name;
            string oldSpecies = animal.Species;
            int oldAge = animal.Age;
            int oldScore = animal.RecoveryScore;

            animal.Name = name;
            animal.Species = species;
            animal.Age = age;
            animal.RecoveryScore = score;
            animal.Reclassify();

            if (!FileManager.RewriteAll(animals))
            {
                // Undo the in-memory change
                animal.Name = oldName;
                animal.Species = oldSpecies;
                animal.Age = oldAge;
                animal.RecoveryScore = oldScore;
                animal.Reclassify();
                return;
            }

            string id = animal.AnimalId;
            string status = animal.Status;
            string housing = animal.HousingUnit;

            RefreshGrid();
            ClearForm();

            MessageBox.Show(
                $"{id} was updated.\n\nStatus: {status}\nHousing Unit: {housing}", "Animal updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Reloads animals from the file and then redisplays them inside the grid
        private int RefreshGrid()
        {
            var result = FileManager.Load();
            int skipped = result.Skipped;

            // Refresh grid
            dgvAnimals.DataSource = null;
            animals = result.Animals;
                        
            dgvAnimals.DataSource = animals;
            dgvAnimals.Columns["AnimalId"].HeaderText = "Animal ID";
            dgvAnimals.Columns["RecoveryScore"].HeaderText = "Recovery Score";
            dgvAnimals.Columns["HousingUnit"].HeaderText = "Housing Unit";


            return skipped;

        }
        //Add feature
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            // Validate fields
            if (!Validator.ValidateAnimalId(txtAnimalID.Text, out string id, out string error))
            {
                ShowFieldError(error, txtAnimalID);
                return;
            }

            // Validator Methods
            if (FindAnimalIndex(id) >= 0)
            {
                ShowFieldError($"Animal ID {id} already exists. Animal ID must be unique.", txtAnimalID);
                return;
            }

            if (!Validator.ValidateName(txtName.Text, out string name, out error))
            {
                ShowFieldError(error, txtName);
                return;
            }
            if (!Validator.ValidateSpecies(txtSpecies.Text, out string species, out error))
            {
                ShowFieldError(error, txtSpecies);
                return;
            }
            if (!Validator.ValidateAge(txtAge.Text, out string ageText, out error))
            {
                ShowFieldError(error, txtAge);
                return;
            }
            if (!Validator.ValidateRecoveryScore(txtScore.Text, out string scoreText, out error))
            {
                ShowFieldError(error, txtScore);
                return;
            }

            int age = int.Parse(ageText, CultureInfo.InvariantCulture);
            int score = int.Parse(scoreText, CultureInfo.InvariantCulture);

            // New Animal object
            Animal animal = new Animal(id, name, species, age, score);

            // On failure FileManager already showed the error, keep the inputs so nothing is lost
            if (!FileManager.AppendAnimal(animal))
            {
                return;
            }

            string status = animal.Status;
            string housing = animal.HousingUnit;

            RefreshGrid();
            ClearForm();

            MessageBox.Show(
                $"{id} was added.\n\nStatus: {status}\nHousing Unit: {housing}",
                "Animal added", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Delete feature
        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loadedId))
            {
                MessageBox.Show(
                    "Load an animal first by clicking its row or searching for its ID.",
                    "Delete Animal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int iIndex = FindAnimalIndex(loadedId);

            if (iIndex < 0)
            {
                MessageBox.Show(
                    "That animal could not be found.",
                    "Delete Animal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                RefreshGrid();
                ClearForm();
                return;
            }

            Animal animal = animals[iIndex];

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete {animal.AnimalId} ({animal.Name})?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            // Remove it from memory, then save the updated list to animals.txt.
            animals.RemoveAt(iIndex);

            if (!FileManager.RewriteAll(animals))
            {
                // Restore it in memory if saving failed.
                animals.Insert(iIndex, animal);
                return;
            }

            RefreshGrid();
            ClearForm();

            MessageBox.Show(
                $"{animal.AnimalId} was deleted.",
                "Animal Deleted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //Summary feature
        private void btnGenerate_Click(object? sender, EventArgs e)
        {
            // Reload first so the summary reflects the current file contents.
            RefreshGrid();

            int iTotal = animals.Count;

            lblTotalValue.Text = iTotal.ToString();

            if (iTotal == 0)
            {
                lblAvgAgeValue.Text = "N/A";
                lblAvgScoreValue.Text = "N/A";
            }
            else
            {
                double averageAge = animals.Average(a => a.Age);
                double averageScore = animals.Average(a => a.RecoveryScore);

                lblAvgAgeValue.Text = averageAge.ToString("F1");
                lblAvgScoreValue.Text = averageScore.ToString("F1");
            }

            lblCriticalValue.Text = animals.Count(a => a.Status == Classifier.Critical).ToString();
            lblSeriousValue.Text = animals.Count(a => a.Status == Classifier.Serious).ToString();
            lblStableValue.Text = animals.Count(a => a.Status == Classifier.Stable).ToString();
            lblRecoveryValue.Text = animals.Count(a => a.Status == Classifier.Recovering).ToString();
            lblReleaseReadyValue.Text = animals.Count(a => a.Status == Classifier.ReleaseReady).ToString();
        }
    }
}
