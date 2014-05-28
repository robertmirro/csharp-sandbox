using System;

class Program2
{
    static void Main()
    {
        Console.WriteLine("Please enter you first name:");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Please enter you last name:");
        string LastName = Console.ReadLine();

        // concantination method
        //Console.WriteLine("hello " + UserName);

        // place holder method
        //Console.WriteLine("hello again {0}", UserName);

        Console.WriteLine("Hola {0}, {1}", FirstName, LastName);
    }
}
