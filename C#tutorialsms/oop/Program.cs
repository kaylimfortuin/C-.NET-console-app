Console.WriteLine("Hello, oop!"); // Prints a greeting message to the console.

// 2 instances of the Person class
// each instance is an object
var p1 = new Person("Kaylim", "Fortuin", new DateOnly(2005, 03, 09)); // Creates a Person object with a first name, last name, and birthday.
var p2 = new Person("Tamika", "Fortuin", new DateOnly(2008, 06, 04)); // Creates another Person object with different details.

p1.Pets.Add(new Cat("Mittens")); // Adds a Cat object named "Mittens" to p1's list of pets.
p1.Pets.Add(new Dog("Rover"));   // Adds a Dog object named "Rover" to p1's list of pets.

p2.Pets.Add(new Cat("Whiskers")); // Adds a Cat object named "Whiskers" to p2's list of pets.
p2.Pets.Add(new Dog("Fido"));     // Adds a Dog object named "Fido" to p2's list of pets.

List<Person> people = [p1, p2]; // Creates a list of Person objects and adds p1 and p2 to it.

foreach (var person in people) // Loops through each Person object in the list.
{
    Console.WriteLine($"{person}"); // Prints the string representation of the Person object.
    foreach (var pet in person.Pets) // Loops through each Pet object in the person's list of pets.
    {
        Console.WriteLine($"{pet}"); // Prints the string representation of the Pet object.
    }
}

// class is an encapsulation of data and methods
public class Person(string firstname, string lastname, DateOnly birthday) // Defines a Person class with a primary constructor.
{
    public string First { get; } = firstname; // Read-only property for the person's first name.
    public string Last { get; } = lastname;   // Read-only property for the person's last name.
    public DateOnly Birthday { get; } = birthday; // Read-only property for the person's birthday.
    public List<Pet> Pets { get; } = new();   // A list to store the person's pets, initialized as empty.

    public override string ToString() // Overrides the default ToString method to provide a custom string representation.
    {
        return $"Human {First} {Last}"; // Returns the person's first and last name.
    }
}

public abstract class Pet(string firstname) // Defines an abstract Pet class with a primary constructor.
{
    public string First { get; } = firstname; // Read-only property for the pet's name.

    public abstract string MakeNoise(); // Abstract method that must be implemented by derived classes.

    public override string ToString() // Overrides the default ToString method to provide a custom string representation.
    {
        return $"{First} and I am a {GetType().Name} and I make noise {MakeNoise()}"; 
        // Returns the pet's name, type, and the noise it makes.
    }
}

public class Cat(string firstname) : Pet(firstname) // Defines a Cat class that inherits from the Pet class.
{
    public override string MakeNoise() { return "meow"; } // Implements the MakeNoise method to return "meow".
}

public class Dog(string firstname) : Pet(firstname) // Defines a Dog class that inherits from the Pet class.
{
    public override string MakeNoise() => "woof"; // Implements the MakeNoise method to return "woof".
}

/*
This program demonstrates basic Object-Oriented Programming (OOP) concepts in C#:

1. **Instances of the `Person` class**:
   - Two `Person` objects (`p1` and `p2`) are created, each representing a person with a first name, last name, and birthday.
   - Each `Person` object has a list of `Pet` objects, which are added dynamically.

2. **The `Person` class**:
   - Encapsulates data such as `First`, `Last`, and `Birthday` using read-only properties.
   - Includes a `Pets` property, which is a list of `Pet` objects.
   - Overrides the `ToString` method to provide a custom string representation of a person.

3. **The `Pet` class**:
   - An abstract class that serves as a base for specific types of pets (e.g., `Cat` and `Dog`).
   - Contains a read-only property `First` for the pet's name and an abstract method `MakeNoise` that must be implemented by derived classes.
   - Overrides the `ToString` method to include the pet's name, type, and the noise it makes.

4. **The `Cat` and `Dog` classes**:
   - Inherit from the `Pet` class and implement the `MakeNoise` method to return "meow" for cats and "woof" for dogs.

5. **Program Flow**:
   - Two `Person` objects are created, and pets are added to their `Pets` lists.
   - A `List` of `Person` objects is created to manage multiple people.
   - A `foreach` loop iterates through the list of people, printing each person's details and their pets' details.

6. **Key OOP Concepts**:
   - **Encapsulation**: Data is encapsulated within classes, and properties are read-only to ensure immutability.
   - **Inheritance**: The `Cat` and `Dog` classes inherit from the `Pet` class, reusing and extending its functionality.
   - **Polymorphism**: The `MakeNoise` method is implemented differently in the `Cat` and `Dog` classes, demonstrating polymorphism.

This program showcases how to create and manage objects, use inheritance, and override methods in C#.
*/




