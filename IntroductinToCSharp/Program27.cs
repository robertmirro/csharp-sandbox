using System;

public class Student27
{
    private int _id;
    private string _name;
    private int _passMark = 35;

    // create a property named "Id"
    // properties are accessed as if they are public sfields (not methods)
    public int Id
    {
        set
        {
            // "value" contains the value passed to Id
            if (value <= 0)
            {
                throw new Exception("Student ID cannot be less than 0.");
            }
            // set this class's ID value if we make it this far
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }

    // name property
    public string Name
    {
        set
        {
            // name cannot be null
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty.");
            }
            this._name = value;
        }
        get
        {
            return string.IsNullOrEmpty(_name) ? "NO NAME" : this._name;
        }
    }

    // only implement get accessor (NOT set accesor) for PassMark in order to implement it as Read Only
    public int PassMark
    {
        get
        {
            return _passMark;
        }
    }

    // in C# 3.0 there are auto implemented properties
    // we can use auto implemented properties to save coding if we don't need to implement coding logic for get/set
    // compiler will create a backing private field for use to store "Email" and automatically read/write to it
    public string Email {get; set;}
}

class Program27
{
    static void Main()
    {
        Student27 S = new Student27();
        //S.Id = -101;  // uncomment to invoke exception handling
        S.Id = 4848;
        //S.Name = null; // uncomment to invoke exception handling
        //S.Name = "";  //uncomment to invoke exception handling
        S.Name = "El Bobbio 2";
        //S.PassMark = 44;  // uncomment to verify that this is a read only property and value cannot be set
        S.Email = "rmirro@gmail.com";
        Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2} && Email = {3}", S.Id, S.Name, S.PassMark, S.Email);
    }
}

