using System;
public sealed class Parent
{
    public string Name { get; set; }
    public Parent()
    {
        Name = "Sriram";
    }
}

public class Child : Parent
{

}

public class MainClass
{
    public static void Main()
    {
        Child c = new Child();
        Console.WriteLine(c.Name);
    }
}