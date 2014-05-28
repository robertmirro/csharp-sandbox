using System;

class Program12
{
    static void Main()
    {
        int TotalCoffeeCost = 0;

        MyStartLabel:
        Console.WriteLine("Select you coffee size: 1 = Small, 2 - Medium, 3 - Large");
        int UserChoice = int.Parse(Console.ReadLine());

        switch (UserChoice)
        { 
            case 1:
                TotalCoffeeCost += 1;
                break;
            case 2:
                TotalCoffeeCost += 2;
                break;
            case 3:
                TotalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine("Your choice of \"{0}\" is invalid.", UserChoice);
                goto MyStartLabel;
        }

        Console.WriteLine("Do you want to buy more coffee - Yes or No?");
        string UserDecision = Console.ReadLine();

        switch (UserDecision.ToLower())
        {
            case "yes":
                goto MyStartLabel;
            default:
                break;
        }

        Console.WriteLine("Thank you shopping with us.");
        Console.WriteLine("Total invoice amount = {0}", TotalCoffeeCost);
    }
}

