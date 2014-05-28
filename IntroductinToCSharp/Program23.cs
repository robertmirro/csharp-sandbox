using System;

public class Employee23
{
    public Employee23()
    {
        Console.WriteLine("Employee23 instantiated");
    }

    public Employee23(string Message)
    {
        Console.WriteLine("Employee21 instantiated, message = {0}", Message);
    }

    public string FirstName = "FN";
    public string LastName = "LN";

    // need to mark this method as "virtual" so derived class can override this method if it chooses to
    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class PartTimeEmployee23 : Employee23
{
    //public void PrintFullName()
    //{
    //    Console.WriteLine(FirstName + " " + LastName + " - Part Time");
    //}

    // need to use "override" in order to override the base version of this method above
    public override void PrintFullName()
    {
        //base.PrintFullName();
        Console.WriteLine(FirstName + " " + LastName + " - Part Time");
    }
}

public class FullTimeEmployee23 : Employee23
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Full Time");
    }
}

public class TemporaryEmployee23 : Employee23
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Temporary");
    }
}

class Program23
{
    static void Main()
    {
        // array is of type base class (parent class), however each array element is loaded with derived class below
        Employee23[] Employees = new Employee23[4];
        Employees[0] = new Employee23();
        Employees[1] = new PartTimeEmployee23();
        Employees[2] = new FullTimeEmployee23();
        Employees[3] = new TemporaryEmployee23();

        foreach (Employee23 e in Employees)
        {
            // this results in the base class method being called each time by default (before "virtual" and "override" were added above)
            // once the base class method is overridden, then output below is produced
            e.PrintFullName();
        }
    }
}

/*
Employee23 instantiated
Employee23 instantiated
Employee23 instantiated
Employee23 instantiated
FN LN
FN LN - Part Time
FN LN - Full Time
FN LN - Temporary
Press any key to continue . . .
*/