using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string first_name = Console.ReadLine();

        Console.Write("What is your las name?");
        string las_name = Console.ReadLine();

        Console.WriteLine($"Your name is {las_name}, {first_name} {las_name}");
    }
}