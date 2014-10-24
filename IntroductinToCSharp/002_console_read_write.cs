using System;

class console_read_write_002
{
    static void Main()
    {
        Console.WriteLine("Please enter you first name:");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Please enter you last name:");
        string LastName = Console.ReadLine();

        // concantination method
        //Console.WriteLine("hello " + UserName);

        // place holder method (preferred method)
        //Console.WriteLine("hello again {0}", UserName);

        Console.WriteLine("Hola {0} {1}", FirstName, LastName);
    }
}
