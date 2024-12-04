using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLinqAnimal
{
    public class Animal
    {
        public string AnimalType { get; set; }
        public string AnimalName { get; set; }
        public byte AnimalAge { get; set; }
        public byte AnimalLegs { get; set; }
        public bool IsVaccinated { get; set; }

        public Animal(string animalType, string animalName, byte animalAge, byte animalLegs, bool isVaccinated)
        {
            AnimalType = animalType;
            AnimalName = animalName;
            AnimalAge = animalAge;
            AnimalLegs = animalLegs;
            IsVaccinated = isVaccinated;
        }

    }
}
