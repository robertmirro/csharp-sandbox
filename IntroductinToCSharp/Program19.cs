using System;

class Program19
{
    static void Main()
    {
        Customer C1 = new Customer("Roberto", "Mirro");
        C1.PrintFullName();

        Customer C2 = new Customer();
        C2.PrintFullName();
    }
}

class Customer
{
    string _firstName;
    string _lastName;

    // class constructor (has same name as its class)
    // constructors are used to initialize class state
    // constructors automatically called when an instance of a class is instantiated
    // constructors can have parameters but does NOT have a return type as other methods do
    // a class is not required to explicitally code a constructor
    // if you dont provide a constructor, .NET will automatically provide a default parameter-less constructor for you
    // if your code does provide an explicit constructor, the default .NET constructor is NOT available (you need to code your own parameter-less constructor if you need one)
    // the default constructor walks through all fields of class and sets them to their defaults 
    //   ex: _firstName is not initiallzed below, but constructor will set it to value, _firstName = string.Empty;
    public Customer(string FirstName, string LastName)
    {
        // can also refer to class members using "this" keyword
        // this refers to an instance (object) of this class
        // this._firstName = FirstName;
        _firstName = FirstName;  
        _lastName = LastName;

    }

    // since we have an explicit constructor above, we now have to create our own default parameter-less constructor if we want one
    // use "this" keyword to refer to this instance of this class and call the parameterized constructor above
    // this is constructor overloading
    public Customer()
        : this("No First Name Provided", "No Last Name Provided")
    {
    }

    // class destructor
    // destructor also has same name of class
    // destructor cant take parameters, dont have a return type and begins with a tilde ("~")
    // destructors are usually used to cleanup resources of your object
    // destructors are called automatically by garbage collection
    ~Customer()
    {
        // cleanup code goes here
    }
    
    // add function (behavior) to this class
    public void PrintFullName()
    {
        Console.WriteLine("Full Name: {0} {1}", _firstName, this._lastName);
    }
}

