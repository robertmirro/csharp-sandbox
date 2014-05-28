using System;

class Program5
{
    static void Main()
    {
        // assignment
        int i = 10;
        bool b = true;

        // arithmethic
        int numerator = 10;
        int denominator = 3;
        int result = numerator / denominator;
        Console.WriteLine("Result: {0}", result);
        Console.WriteLine("Remainder: {0}", numerator % denominator);

        int number = 10;
        int anothernumber = 20;
        if (number == anothernumber)
        {
            Console.WriteLine("number is EQUAL to {0}", anothernumber);
        }
        else
        {
            Console.WriteLine("number is NOT equal to {0}", anothernumber);
        }

        if (number == 10 && anothernumber == 20)
        {
            Console.WriteLine("number is EQUAL to anothernumber");
        }

        bool numberIs10;
        if (number == 10)
        {
            numberIs10 = true;
        }
        else
        {
            numberIs10 = false;
        }
        Console.WriteLine("numberIs10 - 1: {0}", numberIs10);

        // instead of coding like the above, use ternary operator:
        number = 4;
        numberIs10 = (number == 10) ? true : false;
        Console.WriteLine("numberIs10 - 2: {0}", numberIs10);

        // i also like this method
        number = 10;
        numberIs10 = (number == 10);
        Console.WriteLine("numberIs10 - 3: {0}", numberIs10);


    }
}
