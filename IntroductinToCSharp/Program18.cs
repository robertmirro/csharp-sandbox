using System;
//using ProjectA.TeamA;
//using ProjectA.TeamB;
using PATA = ProjectA.TeamA;  // these are namespace aliases
using PATB = ProjectA.TeamB;

class Program18
{
    static void Main()
    {
        Console.WriteLine("Hello");

        ProjectA.TeamA.ClassA.Print(); // fully qualified name reference
        //ClassA.Print();  // 1. added first using statement above, so now we don't need full reference to ClassA
        PATA.ClassA.Print();  // 2. added second using statement above, so now we we can't reference ClassA directly and need to use namespace alias instead (only need to do this if we don't want to use fully qualified references)

        ProjectA.TeamB.ClassA.Print();
        PATB.ClassA.Print();
    }
}

// after creating ProjectA.TeamB project and ClassA.cs, move Print() method to ClassA.cs and comment out all code below
//namespace ProjectA
//{   
//    namespace TeamB
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("Team B Print Method");
//            }
//        }
//    }
//}

// after creating ProjectA.TeamA project and ClassA.cs, move Print() method to ClassA.cs and comment out all code below
//namespace ProjectA
//{
//    namespace TeamA
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("Team A Print Method");
//            }
//        }
//    }
//}