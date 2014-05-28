namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine(
              "SampleMethod inside SampleNamespace");
        }
    }

    // Create a nested namespace, and define another class. 
    namespace NestedNamespace
    {
        class SampleClass
        {
            public void SampleMethod()
            {
                System.Console.WriteLine(
                  "SampleMethod inside NestedNamespace");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Displays "SampleMethod inside SampleNamespace."
            SampleClass outer = new SampleClass();
            outer.SampleMethod();

            // Displays "SampleMethod inside SampleNamespace."
            SampleNamespace.SampleClass outer2 = new SampleNamespace.SampleClass();
            outer2.SampleMethod();

            // Displays "SampleMethod inside NestedNamespace."
            NestedNamespace.SampleClass inner = new NestedNamespace.SampleClass();
            inner.SampleMethod();

            // Displays "SampleMethod inside NestedNamespace."
            SampleNamespace.NestedNamespace.SampleClass inner2 = new NestedNamespace.SampleClass();
            inner.SampleMethod();

            // Displays "SampleMethod inside NestedNamespace."
            SampleNamespace.NestedNamespace.SampleClass inner3 = new SampleNamespace.NestedNamespace.SampleClass();
            inner.SampleMethod();
        }
    }
}

/*
    namespace N1     // N1
    {
        class C1      // N1.C1
        {
            class C2   // N1.C1.C2
            {
            }
        }
        namespace N2  // N1.N2
        {
            class C2   // N1.N2.C2
            {
            }
        }
    }
*/