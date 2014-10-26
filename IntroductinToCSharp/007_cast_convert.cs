using System;

class cast_convert_007
{
    static void Main()
    {
        // this implicit converstion performed by compiler is allowed
        int i = 10;
        float f = i;
        Console.WriteLine("f: {0}" , f);

        // this implicit converstion is not allowed because float can possibly overflow int, as well as losing fraction value
        float ff = 123.432F;
        //int ii = ff;
        Console.WriteLine("ff: {0}", ff);

        // need to do explicit conversion via cast operator (cast will NOT throw exception on overflow)
        int ii = (int)ff;
        // OR via convert class (Convert WILL throw exception on overflow)
        int iii = Convert.ToInt32(ff);

        Console.WriteLine("ii: {0} (fraction is lost)", ii);
        Console.WriteLine("iii: {0} (fraction is lost)", iii);
        
        
        string s = "444";
        int sint;

        // can use Convert but NOT cast
        //sint = (int)s;
        sint = Convert.ToInt32(s);
        Console.WriteLine("sint Convert: {0}", sint);

        // use <type>.Parse method
        sint = int.Parse(s);
        Console.WriteLine("sint Parse: {0}", sint);
        
        // <type>.TryParse()
        string ss = "4448RJM";
        int sint2 = 4;  // set default
        bool isValidInt = int.TryParse(ss, out sint2);  // sint2 = 0 on TryParse fail
        Console.WriteLine("TryParse sint2: {0}", sint2);

        //Console.WriteLine((string)(isValidInt == true ? sint2.ToString() : "Please enter a valid int..."));
        Console.WriteLine((isValidInt == true) ? sint2.ToString() : "Please enter a valid int...");
    }
}
