namespace BaobabRidgeRecordSystem
{
    // This defines what an Animal is in the POV from the App
    internal class Animal
    {
        string animalId, name, species, status, housingUnit;
        int age, recoveryScore;

        // The constructor for the Animal class, which sets the object up when creating an Animal object
        public Animal(string animalId, string name, string species, int age, int recoveryScore)
        {
            AnimalId = animalId;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryScore;
            Reclassify();

        }

        public string AnimalId { get => animalId; private set => animalId = value; }
        public string Name { get => name; set => name = value; }
        public string Species { get => species; set => species = value; }
        public string Status { get => status; private set => status = value; }
        public string HousingUnit { get => housingUnit; private set => housingUnit = value; }
        public int Age { get => age; set => age = value; }
        public int RecoveryScore { get => recoveryScore; set => recoveryScore = value; }



        // This method simply returns a string which will be used to print a line on a file
        public string ToFileLine()
        {
            string result = $"{AnimalId}|{Name}|{Species}|{Age}|{RecoveryScore}|{Status}|{HousingUnit}";

            return result;
        }

        // This method is for the Update feature, to Reclassify an animal's condition
        public void Reclassify()
        {
            var result = Classifier.Classify(RecoveryScore);
            Status = result.Status;
            HousingUnit = result.HousingUnit;
        }
    }
}

