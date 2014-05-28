using System;

class Program25
{
    static void Main()
    {
        Add(4, 8);
        Add(4, 8, 12);
        Add(4, 8, 12, 16);
        Add(44F, 88F);
        Add(444, 888F);

        int myOut;
        Add(84, 8, out myOut);
    }

    // use "static" methods so we can call methods without instantiating an object
    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

    // overload Add method
    // in order to overload, the method signature must differ in the number and/or type and/or kind of parameters
    // NOTE: the return type and "params" modifier of the method does NOT contribute to the signature, so changing these do not constitute an overloaded method
    // NOTE: since "params" method param type is optional, is also not possible to overload a function using this either
    public static void Add(int FN, int SN, int TN)
    {
        Console.WriteLine("Sum = {0}", FN + SN + TN);
    }

    // this is using "params" an is NOT a valid overload
    // this should NOT compile according the video but it does compile and run
    public static void Add(int FN, int SN, int TN, params int[] ForthN)
    {
        Console.WriteLine("Sum = {0}", FN + SN + TN);
    }

    public static void Add(int FN, int SN, int TN, int ForthN)
    {
        Console.WriteLine("Sum = {0}", FN + SN + TN + ForthN);
    }

    // overload method by using different "types" of params
    public static void Add(float FN, float SN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

    // overload method by using different "types" of params
    public static void Add(int FN, float SN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

    // overload using an output param (a different "kind" of param)
    public static void Add(int FN, int SN, out int TN)
    {
        TN = FN * SN;
        Console.WriteLine("Sum = {0}", TN);
        
    }

}

