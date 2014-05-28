using System;

public class BaseClass24
{
    public virtual void Print()
    {
        Console.WriteLine("Base class print method...");
    }
}

public class DerivedClass24 : BaseClass24
{
    // if we change "override" to "new" then the derived class method will NOT be invoked below, instead the hidden method in the base class will be used
    public new /* override */ void Print()
    {
        Console.WriteLine("Derived class print method...");
    }
}

class Program24
{
    static void Main()
    {
        BaseClass24 B = new DerivedClass24();
        B.Print();

        // this is also a way to invoke the derived class method (even if "new" was used on the derived class method)
        DerivedClass24 D = new DerivedClass24();
        D.Print();
    }
}

