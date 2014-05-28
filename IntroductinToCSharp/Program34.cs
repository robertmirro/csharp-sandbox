﻿using System;

class a34
{
    public virtual void Print()
    {
        Console.WriteLine("a34 Print()...");
    }
}

// inherit from a34 class
class b34 : a34
{
    // override Print() method from class a34
    // type "override" then select "Print" method and VS will generate method below
    public override void Print()
    {
        Console.WriteLine("b34 Print()...");

        // comment out default code generated by VS
        // base.Print();
    }
}

// this class also inherits from class a34
class c34 : a34
{
    // override Print() method from class a34
    public override void Print()
    {
        Console.WriteLine("c34 Print()...");

        // comment out default code generated by VS
        //base.Print();
    }
}

// C# does not allow multiple inheritance from classes
// however, if it did, then the code below would cause the Diamond problem (see diagram)
// c35 is commented out below merely so this code will build successfully
class d34 : b34 /* , c34 */
{
}

class Program34
{
    static void Main()
    {
        // d34 does not override Print() so which Print() is invoked, b34.Print() or c34.Print()?
        d34 D = new d34();
        D.Print();
    }
}

