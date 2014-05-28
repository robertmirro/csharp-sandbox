using System;

public class Employee21
{
    public Employee21()
    {
        Console.WriteLine("Employee21 instantiated");
    }

    // overloaded base class constructor
    public Employee21(string Message)
    {
        Console.WriteLine("Employee21 instantiated, message = {0}", Message);
    }

    // don't make these fields public, we should use public properties instead (use "public" for now just for examples sake so they are avail to derived classes below)
    // this class and code is common to both types of employees
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

// use ":" to inherit from Employee21 class in order to create the FullTimeEmployee21 derived class
public class FullTimeEmployee21 : Employee21
{
    public float YearlySalary;

    public FullTimeEmployee21()
    {
        Console.WriteLine("FullTimeEmployee21 instantiated");
    }
}

public class PartTimeEmployee21 : Employee21
{
    public float HourlyRate;

    // add "base" to force new base class constructor above (with param) to be invoked when this child of base is instantiated
    public PartTimeEmployee21() : base("Dervided class is deciding which parent constructor to call...")
    {
        Console.WriteLine("PartTimeEmployee21 instantiated");
    }
}

class Program21
{
    static void Main()
    {
        // full time employee class has access to fields from base class
        FullTimeEmployee21 FTE = new FullTimeEmployee21();
        FTE.FirstName = "Roberto";
        FTE.LastName = "Mirroski";
        FTE.YearlySalary = 444.88F;  // this field is only avail to full time employee class
        FTE.PrintFullName();

        // part time employee
        PartTimeEmployee21 PTE = new PartTimeEmployee21();
        PTE.FirstName = "Lori";
        PTE.LastName = "Malekery";
        PTE.HourlyRate = 69.99F;
        PTE.PrintFullName();


    }
}

