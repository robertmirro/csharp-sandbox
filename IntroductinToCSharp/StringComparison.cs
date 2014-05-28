using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class StringComparison
    {
        static void Main(string[] args)
        {
            compareStrings("El Bobbio", "El Mirrio", true);
            compareStrings("El Bobbio", "El bobbio", true);
            compareStrings("El Bobbio", "el Bobbio", true);
            compareStrings("El Bobbio", "El Bobbio", true);
            Console.WriteLine();

            compareStrings("El Bobbio", "El Mirrio", false);
            compareStrings("El Bobbio", "El bobbio", false);
            compareStrings("El Bobbio", "el Bobbio", false);
            compareStrings("El Bobbio", "El Bobbio", false);
            Console.WriteLine();

            compareStrings("El Bobbio", "El Mirrio");
            compareStrings("El Bobbio", "El bobbio");
            compareStrings("El Bobbio", "el Bobbio");
            compareStrings("El Bobbio", "El Bobbio");
            Console.WriteLine();

            //Console.WriteLine("\"{0}\" and \"{1}\" are equal? {2}", myString, myOtherString, stringsAreEqual(myString, myOtherString).ToString().ToUpper());
            //Console.WriteLine(String.Equals(myString, myOtherString, System.StringComparison.OrdinalIgnoreCase));
        }

        static void compareStrings(string str1, string str2)
        {
            compareStrings(str1, str2, true);
        }

        static void compareStrings(string str1, string str2, bool ignoreCase) 
        {
            Console.WriteLine("\"{0}\" and \"{1}\" are equal? {2}", str1, str2, stringsAreEqual(str1, str2, ignoreCase).ToString().ToUpper());    
        }

        static Boolean stringsAreEqual(string str1, string str2, bool ignoreCase)
        {
            return String.Equals(str1, str2, (ignoreCase) ? System.StringComparison.OrdinalIgnoreCase : System.StringComparison.Ordinal );
        }
    }
}
