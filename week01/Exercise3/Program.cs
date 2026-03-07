using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int real_number = random.Next(1,11);
        //int real_number = 2;
        int guessed_number = 0;

        while (real_number != guessed_number)
        {
            Console.Write("What is the magic number? ");
            guessed_number= int.Parse(Console.ReadLine());
            if (real_number > guessed_number){Console.WriteLine("Higher! ");}
            else if (real_number < guessed_number){Console.WriteLine("Lower! ");}
            else {Console.WriteLine("You got it!");}
        }

    }
}