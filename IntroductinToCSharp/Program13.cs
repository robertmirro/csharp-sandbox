using System;

class Program13
{
    static void Main()
    {
        int bob = new Int32();
        bob = 3;
        Console.WriteLine("bob={0}", bob);

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
    }
}

