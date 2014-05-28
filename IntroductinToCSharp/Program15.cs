using System;

class Program15
{
    static void Main()
    {
        int[] Numbers = new int[3];
        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        
        // used to iterate through collections, not chance of index out of range
        int Counter = 0;
        foreach(int k in Numbers)
        {
            Console.WriteLine("{0} = {1}", Counter, k);
            Counter += 1;
        }
        Console.WriteLine();
        
        for (int j = 0; j < Numbers.Length; j++)
        {
            Console.WriteLine("{0} = {1}", j, Numbers[j]);
        }
        Console.WriteLine();

        int i = 0;
        while (i < Numbers.Length)
        {
            Console.WriteLine("{0} = {1}", i, Numbers[i]);
            i++;
        }
        Console.WriteLine();
    }
}

