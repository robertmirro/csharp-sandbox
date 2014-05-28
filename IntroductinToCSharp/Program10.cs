using System;

class Program10
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int UserNumber = int.Parse(Console.ReadLine());

        if (UserNumber == 1)
        {
            Console.WriteLine("Your number is one");
        }
        if (UserNumber == 2)
        {
            Console.WriteLine("Your number is two");
        }
        if (UserNumber == 3)
        {
            Console.WriteLine("Your number is three");
        }
        if (UserNumber != 1 && UserNumber != 2 && UserNumber != 3)
        {
            Console.WriteLine("Your number is NOT between 1, 2 and 3");
        }

        if (UserNumber == 1)
        {
            Console.WriteLine("Your number is one");
        }
        else if (UserNumber == 2)
        {
            Console.WriteLine("Your number is two");
        }
        else if (UserNumber == 3)
        {
            Console.WriteLine("Your number is three");
        }
        else
        {
            Console.WriteLine("Your number is NOT between 1, 2 and 3");
        }

        if (UserNumber == 10 || UserNumber == 20)
        {
            Console.WriteLine("Your number is 10 OR 20");
        }

    }
}

