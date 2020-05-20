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
    }
}

