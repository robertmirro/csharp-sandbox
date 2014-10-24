using System;

class build_in_types_003  
{
    static void Main(string[] args)
    {
        bool b = true;
        b = false;

        Boolean bb = false;
        bb = true;

        Console.WriteLine("bool/Boolean: {0}/{1}", b, bb);

        byte bbyte = 1;
        bbyte = 255;

        sbyte ssbyte = -128;
        ssbyte = 127;

        int i = 0;
        Console.WriteLine("Integer Min/Max = {0}/{1}", int.MinValue, int.MaxValue);

        double d = 123.22242433987;
        Console.WriteLine("Double: {0}", d);

        decimal dd = 1235678901234.1235678901234M;
        Console.WriteLine("Decimal: {0}", dd);
    }
}
