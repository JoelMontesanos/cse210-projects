using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();

        string name = AskName();
        int number = AskNumber();

        int result = Square(number);

        ShowResult(name, result);
    }

    static void Welcome()
    {
        Console.WriteLine("Welcome!");
    }

    static string AskName()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int AskNumber()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int Square(int num)
    {
        int answer = num * num;
        return answer;
    }

    static void ShowResult(string name, int result)
    {
        Console.WriteLine(name + ", the square of your number is " + result);
    }
}