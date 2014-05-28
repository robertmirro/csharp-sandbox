using System;

// use "abstract" keyword to mark class as being abstract
// an abstract class in an incomplete class
// you cannot create an instance of an abstract class
// abstract can only be used as base class, sealed cannot be used as base class
// cannot mark abstract as "sealed" because that contradicts being "abstract"
public abstract /* sealed */ class Customer32
{
    // abstract method/member also uses "abstract" keyword
    // abstract class is not requried to contain abstract members
    public abstract void Print();
    //{
        // abstract methods are also incomplete and cant contain an implementation (code)
        // comment out body and add semi-colon after print to avoid compile error
    //}

    // abstract classes can also have non-abstract members that contain an implementation
    public void Print2()
    {
        Console.WriteLine("Non-abstract member Print2()...");
    }
}

// non-abstract class Program32 inherits from abstract class Customer32
// non-abstract class must provide implementation for all abstract members within base class (abstract class)
// if Program32 class does not wish to provide implementation for all abstract members, it must be marked as abstract as well
public /* abstract */ class Program32 : Customer32
{
    static void Main()
    {
        Program32 P = new Program32();
        P.Print();
        P.Print2();

        // can also do this thanks to concept of inheritence
        Customer32 C = new Program32();
        C.Print();
        C.Print2();
    }

    // provide implementation of abstract members
    // must use override keyword when implementing abstract members
    public override void Print()
    {
        Console.WriteLine("Abstract member Print()...");
    }
}

