using System;

public class Person
{
    private string[] _phoneNumbers = new string[2];

    // Auto-implemented property
    public string Name { get; set; }

    // Property with backing field
    private int _age;
    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0)
                _age = value;
            else
                throw new ArgumentException("Age cannot be negative.");
        }
    }

    // Indexer for accessing phone numbers
    public string this[int index]
    {
        get { return _phoneNumbers[index]; }
        set { _phoneNumbers[index] = value; }
    }

    // Member function
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person
        {
            Name = "John Doe",
            Age = 30
        };

        // Using the indexer to set phone numbers
        person[0] = "123-456-7890";
        person[1] = "098-765-4321";

        // Calling the member function
        person.Introduce();

        // Accessing phone numbers using the indexer
        Console.WriteLine($"Phone numbers: {person[0]}, {person[1]}");
    }
}