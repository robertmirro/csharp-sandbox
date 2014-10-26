using System;

class nullable_types_006
{
    static void Main()
    {
        bool? bb = true;
        Console.WriteLine("b = {0}, b.Value = {1}", bb, bb.Value);

        int? i = null;
        Console.WriteLine("i = {0}", i);

        bool? b = null;
        Console.WriteLine("b = {0} , b == null: {1} , b.HasValue: {2} " , b , b == null , b.HasValue);

        // .Value returns bool type, NOT nullable bool type
        bool bBool = b.HasValue ? b.Value : false;
        Console.WriteLine("bBool = {0}", bBool);

        
        // <T>? is shorthand syntax for System.Nullable<T>
        System.Nullable<int> nullableInt = null;
        Console.WriteLine("nullableInt.hasValue: {0}", nullableInt.HasValue);


        int? ticketsOnSale = null;
        int ticketsAvailable;

        // cannot implicitly convert non-nullable int to a nullable int
        //ticketsAvailable = (ticketsOnSale.HasValue) ? ticketsOnSale : 0 ;

        // however, can use .value to do conversion because that returns nullable int value
        ticketsAvailable = (ticketsOnSale.HasValue) ? ticketsOnSale.Value : 0;

        // we can also explicitly cast nullable int to an int
        ticketsAvailable = (ticketsOnSale.HasValue) ? (int)ticketsOnSale : 0;

        // OR we can use NULL coalescing operator (use value of variable or use 0 if null)
        ticketsAvailable = ticketsOnSale ?? 0;


        // The syntax T? is shorthand for Nullable<T>, where T is a value type. The two forms are interchangeable.
        int? null1 = 4;
        Console.WriteLine("null1={0}, null1.HasValue={1}, null1.GetValueOrDefault()={2}", null1, null1.HasValue, null1.GetValueOrDefault());

        Nullable<int> null2 = null;
        Console.WriteLine("null2={0}, null2.HasValue={1}, null2.GetValueOrDefault()={2}", null2, null2.HasValue, null2.GetValueOrDefault());
    }
}
