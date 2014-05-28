using System;

public class Customer29
{
    public int ID { get; set; }
    public string Name { get; set; }
}

class Program29
{
    static void Main()
    {
        // the scope of these int variables is the entire Main method
        // they need to be available until the runtime completes running the Main method
        int i = 0;  // "int" is actually a struct that is defined by System.Int32 (hover over "int" to see this)
        System.Int32 i2 = 0; // this is exactly same as using "int" above

        if (1 == 10)
        {
            // this "j" int variable only needs to be available in the "if" block
            // "j" is a value type and will be destroyed upon completion of the "if" block
            int j = 20;

            // C1 reference varialble will also be destroyed upon completion of the "if" block
            // the Customer29 object will remain on heap and will be destroyed by garbage collection later on behind the scenes
            Customer29 C1 = new Customer29();
            C1.ID = 44;
            C1.Name = "BobbyBoy";
        }
        Console.WriteLine("IF block is complete, j int AND C1 reference variable will be destroyed...");

        // these ints are value types
        // copying one value type into another value type creates a new/separate value type in memory on the stack
        int ii = 10;
        int jj = ii;
        jj = jj + 1;
        // verify that 2 separate value types exist on the stack because their actual values are no longer the same
        Console.WriteLine("ii = {0}, jj = {1}", ii, jj);

        // create a object reference variable and instantiate a new object for it to point to
        Customer29 C2 = new Customer29();
        C2.ID = 4444;
        C2.Name = "MyOriginal";
        // copy the object reference variable above into a new object reference variable
        // this only creates a copy of the reference variable and NOT a copy of the object the var points to
        Customer29 C3 = C2;
        C3.ID = 8888;
        C3.Name = "NewCopy";
        // verify that both object reference variables are pointing to a single object
        Console.WriteLine("C2.ID = {0}, C2.Name = {1}", C2.ID, C2.Name);
        Console.WriteLine("C3.ID = {0}, C3.Name = {1}", C3.ID, C3.Name);

    }
}

