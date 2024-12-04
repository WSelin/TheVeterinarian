namespace ExerciseLinqAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalList animalList = new AnimalList();
            var numberOfDogs = animalList.Animals
                .Count(animal => animal.AnimalType == "Hund");
            Console.WriteLine(numberOfDogs);

            var oldestAnimal = animalList.Animals
                .Max(animal => animal.AnimalAge);
            Console.WriteLine(oldestAnimal);

            var animalIsVaccinated = animalList.Animals
                .Where(animal => animal.IsVaccinated == true).ToList();

            animalIsVaccinated.ForEach(animal => Console.WriteLine($"Animal is vaccinated: {animal.AnimalType}"));

            var animalIsOlderThanThreeAndFourYears = animalList.Animals
                .Count(animal => animal.AnimalLegs >= 4 && animal.AnimalAge > 3);
            Console.WriteLine(animalIsOlderThanThreeAndFourYears);

            var animalName = animalList.Animals
                .Any(animal => animal.AnimalName == "Shadow");
            Console.WriteLine(animalName);
        }
    }
}
