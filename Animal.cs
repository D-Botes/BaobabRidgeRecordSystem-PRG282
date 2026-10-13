namespace BaobabRidgeRecordSystem
{
    // This defines what an Animal is in the POV from the App
    internal class Animal
    {
        string animalId, name, species, status, housingUnit;
        int age, recoveryScore;

        // The constructor for the Animal class, which sets the object up when creating an Animal object
        public Animal(string animalId, string name, string species, string status, string housingUnit, int age, int recoveryScore)
        {
            AnimalId = animalId;
            Name = name;
            Species = species;
            Status = status;
            HousingUnit = housingUnit;
            Age = age;
            RecoveryScore = recoveryScore;
        }

        public string AnimalId { get => animalId; private set => animalId = value; }
        public string Name { get => name; set => name = value; }
        public string Species { get => species; set => species = value; }
        public string Status { get => status; set => status = value; }
        public string HousingUnit { get => housingUnit; set => housingUnit = value; }
        public int Age { get => age; set => age = value; }
        public int RecoveryScore { get => recoveryScore; set => recoveryScore = value; }

        // This method simply returns a string which will be used to print a line on a file
        public string ToFileLine()
        {
            string result = $"{AnimalId}|{Name}|{Species}|{Age}|{RecoveryScore}|{Status}|{HousingUnit}";

            return result;
        }
    }
}

