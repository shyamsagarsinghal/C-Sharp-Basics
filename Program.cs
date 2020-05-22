using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Name: ");
        string FirstName = Console.ReadLine();

        Console.Write("Enter Second Name: ");
        string LastName = Console.ReadLine();

        Console.WriteLine("Hello " + FirstName + " " + LastName); // Concatenation
        Console.WriteLine("Hello {0} {1}", FirstName, LastName); // Place Holder Syntax
        Console.WriteLine($"Hello {FirstName} {LastName}");     // $ sign is a short hand on string interpolation
        Console.ReadLine();

        //Note 1: A namespace is used to organize your code and is collection of classes, interfaces, structs, enums, namespace and delegates.
        //Note 2: To write to Console, there are three Types as mentioned above
        //Note 3: C# is a case sensitive Language

        //Boolean Types - true or false

        //Integral Types - sbyte, byte, short, ushort, int, unit, long, ulong, char
        Console.WriteLine("Integer Min Value: {0}", int.MinValue);
        Console.WriteLine("Integer Max Value: {0}", int.MaxValue); // using this we can know what is the minimum and maximum value of the particular data type

        Console.WriteLine();

        //Floating Types - float and double
        Console.WriteLine("Float Min Value: {0}", float.MinValue);
        Console.WriteLine("Double Max Value: {0}", double.MaxValue);

        Console.WriteLine();

        //Decimal Types
        Console.WriteLine("Decimal Min Value: {0}", decimal.MinValue);
        Console.WriteLine("Decimal Max Value: {0}", decimal.MaxValue);

        //String Type
        string Name = " \"Shyam\" ";   //This is called Escape Sequences.. There are many types of Escape Sequences
        Console.WriteLine(Name);
    }
}

