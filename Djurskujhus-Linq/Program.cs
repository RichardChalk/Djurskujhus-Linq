namespace Djurskujhus_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en lista med 11 djur
            List<Animal> animals = new List<Animal>
            {
                new Animal("Dog", "Buddy", 5, 4, true, Colour.Brown),
                new Animal("Cat", "Whiskers", 3, 4, true, Colour.White),
                new Animal("Parrot", "Polly", 2, 2, false, Colour.Patterned),
                new Animal("Rabbit", "Fluffy", 1, 4, true, Colour.White),
                new Animal("Horse", "Shadow", 10, 4, false, Colour.Black),
                new Animal("Dog", "Bella", 8, 4, true, Colour.Brown),
                new Animal("Chicken", "Clucky", 2, 2, true, Colour.White),
                new Animal("Goat", "Billy", 4, 4, false, Colour.Patterned),
                new Animal("Pig", "Oinky", 6, 4, true, Colour.Brown),
                new Animal("Fish", "Goldie", 1, 0, false, Colour.Patterned),
                new Animal("Turtle", "Shelly", 50, 4, false, Colour.Patterned)
            };

            // 1. Hur många hundar?
            int numberOfDogs = animals
                .Count(a => a.Species == "Dog");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Number of Dogs:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{numberOfDogs}");

            // 2. Äldsta djuret
            Animal? oldestAnimal = animals
                .OrderByDescending(a => a.Age)
                .FirstOrDefault();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nOldest Animal:");
            Console.ForegroundColor = ConsoleColor.Gray;
            oldestAnimal?.DisplayInfo();

            // 3. Ny lista med bara vaccinerade djur
            List<Animal> vaccinatedAnimals = animals
                .Where(a => a.Vaccinated)
                .ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nVaccinated Animals:");
            Console.ForegroundColor = ConsoleColor.Gray;
            vaccinatedAnimals.ForEach(a => a.DisplayInfo());

            // 4. Ny lista med 4-benta djur äldre än 3 år
            List<Animal> fourLeggedOlderThanThree = animals
                .Where(a => a.NumberOfLegs == 4 && a.Age > 3).ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n4-Legged Animals Older Than 3 Years:");
            Console.ForegroundColor = ConsoleColor.Gray;
            fourLeggedOlderThanThree
                .ForEach(a => a.DisplayInfo());

            // 5. Finns det ett djur som heter Shadow?
            bool isShadowPresent = animals
                .Any(a => a.Name == "Shadow");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nIs there an animal named Shadow?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{isShadowPresent}");
        }
    }
}
