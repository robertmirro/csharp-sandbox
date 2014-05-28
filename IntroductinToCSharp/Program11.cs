using System;

class Program11
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int UserNumber = int.Parse(Console.ReadLine());

        switch (UserNumber)
        {
            case 10:
                Console.WriteLine("Your number is 10.");
                break;
            case 20:
                Console.WriteLine("Your number is 20..");
                break;
            case 30:
            case 40:
            case 50:
                Console.WriteLine("Your number is {0}...", UserNumber);
                break;
            default:
                Console.WriteLine("Your number is NOT 10, 20, 30, 40 or 50");
                break;
        }
    }
}

