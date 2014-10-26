using System;

class cast_convert_007
{
    static void Main()
    {
        // this implicit converstion performed by compiler is allowed
        int i = 10;
        float f = i;
        Console.WriteLine(i);

        // this implicit converstion is not allowed because float can possibly overflow int, as well as losing fraction value
        float ff = 123.456F;
        //int ii = ff;

        // need to do explicit conversion like this using cast operator
        int ii = (int)ff;
        // or like this using convert class
        int iii = Convert.ToInt32(ff);
        
        Console.WriteLine(ii);
        Console.WriteLine(iii);

        // use parse method
        string s = "444";
        int sint = int.Parse(s);
        Console.WriteLine(sint);

        string ss = "4448RJM";
        int sint2;
        bool isValidInt = int.TryParse(ss, out sint2);
        //Console.WriteLine((string)(isValidInt == true ? sint2.ToString() : "Please enter a valid int..."));
        Console.WriteLine((isValidInt == true) ? sint2.ToString() : "Please enter a valid int...");
    }
}
