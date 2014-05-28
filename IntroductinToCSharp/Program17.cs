using System;

class Program17
{
    static void Main()
    {
        // pass i as value (not reference), so i remains 0 below
        int i = 0;
        SimpleMethod(i);  // call also call it Program17.SimpleMethod(i);
        Console.WriteLine(i);

        // pass i as reference (not value), so i is changed to 102
        i = 0;
        SimpleMethod2(ref i);  // call also call it Program17.SimpleMethod(i);
        Console.WriteLine(i);

        // this method returns a value without having to use a reference parameter
        int ii = SimpleMethod3(4, 8);
        Console.WriteLine(ii);

        // this method does not return a value but returns output params because it needs to return multiple values
        int mySum = 0;
        int myProduct = 0;
        SimpleMethod4(44, 88, out mySum, out myProduct);
        Console.WriteLine("Sum = {0}, Product = {1}", mySum, myProduct);

        // pass an array as a parameter
        int[] myNumbers = new int[4];
        myNumbers[0] = 101;
        myNumbers[1] = 201;
        myNumbers[2] = 301;
        myNumbers[3] = 401;
        SimpleMethod5();
        SimpleMethod5(myNumbers);
        SimpleMethod5(2, 4, 8);
    }

    // using params keyword makes the array parameter OPTIONAL (you can call method and pass nothing)
    // if method has multiple params, te "params" parameter needs to be LAST and there can on by ONE params parameter
    public static void SimpleMethod5(params int[] NumbersArray)
    {
        Console.WriteLine("Array elements: {0}", NumbersArray.Length);
        foreach (int i in NumbersArray)
        {
            Console.WriteLine(i);
        }
    }

    public static void SimpleMethod4(int FirstNumber, int SecondNumber, out int Sum, out int Product)
    {
        Sum = FirstNumber + SecondNumber;
        Product = FirstNumber * SecondNumber;
    }

    public static int SimpleMethod3(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }

    public static void SimpleMethod2(ref int j)
    {
        j = 102;
    }

    public static void SimpleMethod(int j)
    {
        j = 101;
    }
}

