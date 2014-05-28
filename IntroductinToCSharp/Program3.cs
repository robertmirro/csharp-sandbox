using System;

class Program3  
{
    static void Main()
    {
        bool b = true;
        b = false;

        Boolean bb = false;
        bb = true;

        byte bbyte = 1;
        bbyte = 255;

        int i = 0;
        Console.WriteLine("Integer Min/Max = {0}/{1}", int.MinValue, int.MaxValue);

        double d = 123.22242433987;
        Console.WriteLine("Double: {0}", d);

        decimal dd = 1235678901234.1235678901234M;
        Console.WriteLine("Decimal: {0}", dd);

        //Console.WriteLine("Please enter you first name:");
        //string FirstName = Console.ReadLine();

        //Console.WriteLine("Please enter you last name:");
        //string LastName = Console.ReadLine();

        //// concantination method
        ////Console.WriteLine("hello " + UserName);

        //// place holder method
        ////Console.WriteLine("hello again {0}", UserName);

        //Console.WriteLine("Hola {0}, {1}", FirstName, LastName);
    }
}
