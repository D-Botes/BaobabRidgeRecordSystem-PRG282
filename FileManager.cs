using System.Text.RegularExpressions;

namespace BaobabRidgeRecordSystem
{   // Static class since it does not hold data of its own
    static class FileManager
    {
        // Path to animals.txt, AppContext.BaseDirectory is a property that gets the folder where the .exe is running from
        // Path.Combine joins the folder and filename so we never build paths by hand
        private static readonly string FilePath = Path.Combine(AppContext.BaseDirectory, "animals.txt");

        // This method is used to load the animals.txt
        public static (List<Animal> Animals, int Skipped) Load()
        {
            List<Animal> animals = new List<Animal>();
            int skipped = 0;

            try
            {
                if (!File.Exists(FilePath))
                {
                    // Dispose releases all resources in the stream
                    File.Create(FilePath).Dispose();
                    return (animals, 0);
                }

                string[] lines = File.ReadAllLines(FilePath);

                foreach (string line in lines)
                {
                    // Check to see if the line is blank, if so then skip
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        skipped++;
                        continue;
                    }

                    // An array that takes the line and splits it into parts where there is a |
                    string[] parts = line.Split('|');

                    // Checks if there are 7 parts
                    if (parts.Length != 7)
                    {
                        skipped++;
                        continue;
                    }

                    // Assign id as the first part, and check its formatting
                    string id = parts[0].Trim().ToUpper();
                    if (!Regex.IsMatch(id, @"^WR-\d{4}$"))
                    {
                        skipped++;
                        continue;
                    }

                    // Assign name, species as their respective parts
                    string name = parts[1].Trim();
                    string species = parts[2].Trim();

                    // Instead of int.parse we use this because TryParse since it will return false instead of crashing on a non numeric text
                    if (!int.TryParse(parts[3].Trim(), out int age) || !int.TryParse(parts[4].Trim(), out int score))
                    {
                        skipped++;
                        continue;
                    }

                    // Boundary limits for age and score check
                    if (age < 0 || age > 100 || score < 0 || score > 100)
                    {
                        skipped++;
                        continue;
                    }

                    // Add them to the list if all checks succeed
                    animals.Add(new Animal(id, name, species, age, score));

                }
            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permissions to view animals.txt");
            }

            catch (IOException)
            {
                MessageBox.Show("File is currently in use or unavailable");
            }

            // Return list and skipped counter
            return (animals, skipped);


        }

        // This method appends one animal as a new line a the end of animals.txt
        public static bool AppendAnimal(Animal animal)
        {
            try
            {

                string line = animal.ToFileLine();
                string text = line + Environment.NewLine;
                string existing = "";

                // Check if file exists
                if (File.Exists(FilePath))
                {
                    existing = File.ReadAllText(FilePath);
                }

                // Checks if file is empty
                if (existing.Length > 0 && !existing.EndsWith("\n"))
                {
                    text = Environment.NewLine + text;
                }
                File.AppendAllText(FilePath, text);

                return true;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to edit animals.txt");
                return false;
            }
            catch (IOException)
            {
                MessageBox.Show("File is currently in use or unavailable");
                return false;
            }
        }

        // This method is used to overwrite animals.txt
        public static bool RewriteAll(List<Animal> animals)
        {
            try
            {
                // Empty list to store the lines
                List<string> list = new List<string>();

                // Loops each animal and writes to the empty list
                foreach (Animal animal in animals)
                {
                    list.Add(animal.ToFileLine());
                }

                // Writes the new list
                File.WriteAllLines(FilePath, list);

                return true;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to rewrite animals.txt");
                return false;
            }
            catch (IOException)
            {
                MessageBox.Show("File is currently in use or unavailable");
                return false;
            }
        }
    }
}
