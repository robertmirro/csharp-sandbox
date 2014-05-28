using System;

class Circle20
{
    // change _pi below to be static by adding "static" modifier as: static float _pi = 3.141F; 
    // float _pi = 3.141F;
    
    // now change _pi to no be initialized here (initialze below in static constructor instead)
    //static float _pi = 3.141F;
    static float _pi;

    int _radius;

    // we can use a static constructor to initialize static members
    // access modifiers are not allowed on static constructors
    // static constructors are called once (and ONLY once) before instance constructors
    // static constructor is called even before you refer to any static members of the class
    // NOTE: if access modifiers are NOT specified in general, the member is considered PRIVATE
    static Circle20()
    {
        Console.WriteLine("Static constructor invoked...");
        Circle20._pi = 3.141F;
    }

    // this is an instance constructor
    public Circle20(int radius)
    {
        Console.WriteLine("Instance constructor invoked...");
        this._radius = radius;
    }

    // this is also a static method
    public static void Print20()
    {
        // 
    }

    // this is an instance method
    public float CalculateArea()
    {
        // now that _pi is static, "this" cannot be used because "this" points to an instance of a class (an object) and static members are not instance members
        // instead of "this", must use class name to reference static members
        // return this._pi * this._radius * this._radius;
        return Circle20._pi * this._radius * this._radius;

    }
}

class Program20
{
    static void Main()
    {
        Circle20 c1 = new Circle20(5);
        float Area1 = c1.CalculateArea();
        // need to use name of class to call static method (same as referring to _pi above)
        Circle20.Print20();
        Console.WriteLine("Area1 = {0}", Area1);

        Circle20 c2 = new Circle20(6);
        float Area2 = c2.CalculateArea();
        Console.WriteLine("Area2 = {0}", Area2);
    }
}

