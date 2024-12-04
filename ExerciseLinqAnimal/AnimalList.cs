namespace ExerciseLinqAnimal
{
    public class AnimalList
    {
        public List<Animal> Animals { get; set; }

        public AnimalList()
        {
            Animals = new List<Animal>();
            // Type, Name, Age, Legs, IsVaccinated
            Animals.Add(new Animal("Hund", "Shadow", 1, 4, false));
            Animals.Add(new Animal("Katt", "", 3, 4, true));
            Animals.Add(new Animal("Hamster", "", 1, 4, true));
            Animals.Add(new Animal("Häst", "", 2, 4, true));
            Animals.Add(new Animal("Papegoja", "", 7, 2, true));
            Animals.Add(new Animal("Kanin", "", 2, 4, false));
            Animals.Add(new Animal("Sköldpadda", "", 10, 4, true));
            Animals.Add(new Animal("Marsvin", "", 1, 4, false));
            Animals.Add(new Animal("Kossa", "", 3, 4, false));
            Animals.Add(new Animal("Orm", "", 2, 0, true));
            Animals.Add(new Animal("Igelkott", "", 1, 4, false));

        }
    }
}
