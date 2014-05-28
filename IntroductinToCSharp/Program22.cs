using System;

public class Employee22
{
    public Employee22()
    {
        Console.WriteLine("Employee21 instantiated");
    }

    public Employee22(string Message)
    {
        Console.WriteLine("Employee21 instantiated, message = {0}", Message);
    }

    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class PartTimeEmployee22 : Employee22
{
    public string PtEmp;

    // this method is the same name as the base class method, so it hides the base class method
    // add "new" keyword to make green squiggly under "PrintFullName" (compiler warning) to go away
    public new void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Contractor");

        // (1) call the hidden method of the base class using "base" keyword
        base.PrintFullName();
    }
}

public class FullTimeEmployee22 : Employee22
{
}

class Program22
{
    static void Main()
    {
        FullTimeEmployee22 FTE = new FullTimeEmployee22();
        FTE.FirstName = "FullTime";
        FTE.LastName = "Employee";
        FTE.PrintFullName();

        PartTimeEmployee22 PTE = new PartTimeEmployee22();
        PTE.FirstName = "PartTime";
        PTE.LastName = "Employee";
        PTE.PrintFullName();

        // (2) call the hidden method of the base class using casting (cast child class to base class)
        ((Employee22)PTE).PrintFullName();

        // (3) call hidden method of base class by using "new" to assign the child class to the parent class reference variables (only base class member are available to PTEE)
        // this is possible because parent class can fullfill all responsibilities of the child class, but not vice versa
        Employee22 PTEE = new PartTimeEmployee22();
        PTEE.FirstName = "PartTime";
        PTEE.LastName = "Employee";
        PTEE.PrintFullName();
    }
}

