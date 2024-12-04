namespace Djurskujhus_Linq;

public enum Colour
{
    Black,
    White,
    Brown,
    Patterned
}


public class Animal
{
    // Properties
    public string Species { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int NumberOfLegs { get; set; }
    public bool Vaccinated { get; set; }
    public Colour Colour { get; set; }

    // Constructor
    public Animal(string species, string name, int age, int numberOfLegs, bool vaccinated, Colour colour)
    {
        Species = species;
        Name = name;
        Age = age;
        NumberOfLegs = numberOfLegs;
        Vaccinated = vaccinated;
        Colour = colour;
    }

    // Method to display animal info
    public void DisplayInfo()
    {
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Number of Legs: {NumberOfLegs}");
        Console.WriteLine($"Vaccinated: {(Vaccinated ? "Yes" : "No")}");
        Console.WriteLine($"Colour: {Colour}");
    }
}
