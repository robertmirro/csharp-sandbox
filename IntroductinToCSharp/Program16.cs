using System;

class Program16
{
    // this is a STATIC method, "public" has been added for this example
    //static void Main()
    public static void  Main()
    {
        // GetEvenNumbers is an instance method, so a instance of the Program16 
        // class must be instantied to invoke the method
        Program16 p = new Program16();
        p.GetEvenNumbers(12);
        Console.WriteLine("---------");
        Program16.GetEvenNumbers2();  // can also use just GetEvenNumbers2();
        Console.WriteLine("---------");
        Console.WriteLine("Add Numbers: {0}", p.AddNumbers(4, 4));
    }

    // this INSTANCE method has no return value and 1 param (a method is an intance
    // method if the "static" acces modifier is NOT present
    public void GetEvenNumbers(int NumberLimit)
    {
        int Start = 0;
        while (Start <= NumberLimit)
        {
            Console.WriteLine(Start);
            Start += 2;
        }
    }

    // this STATIC method is the same as INSTANCE method above (static methods cannot 
    // be invoked like instance methods (ex, like p.GetEvenNubmers();)
    public static void GetEvenNumbers2()
    {
        int Start = 0;
        while (Start <= 20)
        {
            Console.WriteLine(Start);
            Start += 2;
        }
    }

    // this INSTANCE method has a return value and multiple params
    public int AddNumbers(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }
}

