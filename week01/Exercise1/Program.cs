using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("what is your first name?");
        string FirstName = Console.ReadLine(); 
        Console.WriteLine("what is your last name?");
        string LastName = Console.ReadLine();
        Console.WriteLine($"Your name is {LastName}, {FirstName}, {LastName}.");
    }
}