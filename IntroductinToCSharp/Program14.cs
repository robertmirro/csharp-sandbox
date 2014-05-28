using System;

class Program14
{
    static void Main()
    {
        string UserChoice = "yes";

        do 
        {
            Console.Clear();
            Console.WriteLine("Please enter your target number:");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;
            while (Start <= UserTarget)
            {
                //Console.WriteLine(Start);
                Console.Write("{0} ", Start);
                Start += 2;
            }
            Console.WriteLine();

            do
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to continue?  yes or no:");
                UserChoice = Console.ReadLine().ToLower();

                if (UserChoice != "yes" && UserChoice != "no")
                {
                    Console.WriteLine("Invalid choice, please try again...");
                }
            }
            while (UserChoice != "yes" && UserChoice != "no");
        
        }
        while (UserChoice == "yes");
    }
}

