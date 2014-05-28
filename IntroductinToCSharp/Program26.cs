using System;

public class Student26
{
    public int ID;
    public string Name;
    public int PassMark = 35;

}

public class Student26_2
{
    private int _id;
    private string _name;
    private int _passMark = 35;

    // use setter method to control private field value
    public void SetId(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student ID cannot be less than 0.");
        }
        // set this class's ID value if we make it this far
        this._id = Id;
    }

    // use getter method to return private field value
    public int GetId()
    {
        return this._id;
    }

    public void SetName(string Name)
    {
        // name cannot be null
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be null or empty.");
        }
        this._name = Name;
    }

    // if a _name value is not specified, return a value to indicate this
    public string GetName()
    {
        return string.IsNullOrEmpty(_name) ? "NO NAME" : this._name;
    }

    // _passMark is meant to be read only so only implement getter method for it
    public int GetPassMark()
    {
        return _passMark;
    }
}

public class Program26
{
    static void Main()
    {
        // using public fields like this means we have no control over values that are assigned
        // none of the rules mentioned in the "problems with public fields" pic can be enforced
        Student26 S = new Student26();
        S.ID = -101;
        S.Name = null;
        S.PassMark = 0;
        Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}", S.ID, S.Name, S.PassMark);

        // if we want to control values to achieve encapsulation, we should used private fields and properties instead of public fields
        // some languages use getter/setter methods, however we can use properties in C#
        // this example shows using getter/setter methods in C#
        Student26_2 S2 = new Student26_2();
        // S2.SetId(-4);
        S2.SetId(4);
        //S2.SetName(null);  // uncomment this to invoke exception logic
        //S2.SetName("");  // uncomment this to invoke exception logic
        S2.SetName("El Bobbio");  // comment this to invoke "NO NAME" logic
        Console.WriteLine("Student ID = {0} && Name = {1} && PassMark = {2}", S2.GetId(), S2.GetName(), S2.GetPassMark());
    }
}

