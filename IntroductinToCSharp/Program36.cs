using System;

// a delegate is a type safe function (method) pointer
// think of the delegate syntax as a method with the "delegate" keyword
// this delegate can point to ANY method that has (1) void return type and (2) a single string parameter (this is what "type safe" means)
public delegate void HelloMethodDelegate(string Message);

class Program36
{
    static void Main()
    {
        // we can call Hello method manually
        Hello("manual hello");

        // need to create an instance of a delegate in order to make it point to a method (Hello)
        // this is where a delegate is similar to a class
        // invoke delegate with a string argument in order to call the Hello method
        HelloMethodDelegate myDelegate = new HelloMethodDelegate(Hello);
        myDelegate("hello from my delegate");
        
    }

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}

