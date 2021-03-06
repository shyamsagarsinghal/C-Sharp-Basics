﻿using System;
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












        //Assignment Operator: =
        //Arithmetic Operator: +, -, *, /, %
        //Comparison Operator: ==, !=, >, >=, <, <=
        //Conditional Operator: &&, ||
        //Ternary Operator: ?:
        int number = 0;
        bool IsNumber10 = number == 10 ? true : false;


        //Values Types: int, float, double, bool, structs, enums, etc
        //Reference Types: Interface, class, delegates, arrays etc

        //Values Types can be divded into two parts:
        //1.Nullable Value Type
        //2.Non-Nullable Value Type

        //By default Value Types are Non-Nullable. For Ex: int i = null; (this statement will give an error)
        //To make it Nullable use either "Nullable" keyword or '?' 
        //For Ex: Nullable <int> x = null; or int? = null;

        //Main usage of this nullable type is when we are passing any parameter to Stored Procedure or Database objects.If a column in a Table allows Null value , then in this case we should use Nullable type. 
        //For example, say I have a Stored Procedure which accepts two in parameter @A and @B. It gives me back one out Parameter @C.
        //This output Parameter can be Null also.So in that case we should  use a Nullable Variable which can take Null also as allowed values.
        //So to conclude, Nullable Types  allows us to declare variables in .net which can be used effectively while dealing with Database.

        //A Nullable Type is incompatible with a General Data Type. This means that we can not have an operation between a nullable  type and general datatype.
        int? x = 4;
        int y = 3;
        int z = x * y; // Cannot implicitly convert type 'int?' to 'int'. An explicit conversion exists (are you missing a cast?)
        Console.WriteLine(z.ToString());
        Console.ReadLine();
        //To avoid this error z variable should also be a nullable type. For Ex: int? z = x * y; this will resolve the issue

        //Operation of a nullable Type is possible with not-nullable type(as seen above).
        //But we can always compare a Nullable Type with a Not Nullable type.
        int? a = 3;
        int b = 3;
        bool check = false;
        if (a == b)
        {
            check = true;
            Console.WriteLine(check.ToString());
            Console.ReadLine();
        }
        //Output will be true

        //Note: Nullable type concept is not compatible with "var".

        //null coalescing operator: ??
        int? x = null;
        int y = 4;
        int? result;
        result = x ?? y;
        Console.WriteLine(result.ToString());
        Console.ReadLine();

        //This operator assigned the value of "x" to" result " if "x" is null else it will assign the value of "y" to "result".
        //So if the first variable is null then that value will be assigned else the value of the second variable will be assigned.
        //As expected in the above case "result" will hold Null.
        //Caution: As variable "result" can also have null, therefore it should be defined as Nullable Type.

        //Note: Assigning Nullable Type variable Value to a Not Nullable Type
        int? x = 4;
        int y = x ?? 0;
        //Now y will have value of x i.e. 4. 
        //In place of 0 in statement int y = x ?? 0; any integer can be used
        //Whatever the integer you use will be the default value of "y".

        //Datatypes Conversion
        //1.Implicit Conversion
        //2.Explicit Conversion
        //3.Difference betwen Parse() and TryParse()

        //1.Implicit Conversion
        int i = 100;
        float f = i; //This is an implicit conversion
        //Implicit Conversion is done by the compiler when there is no loss of information and no possiblity of throwing exceptions during converison
        //If considered above statement, Converting an int to a float will no loose any data and no exception will be thrown

        //2.Explicit Conversion
        float f = 123.45F;
        int i = f;  // It will throw an error "Cannot implicitly convert type 'float' to 'int'.
        //The above statement can be converted by doing Explicit Conversion
        int i = (int)f; // type cast operator
        int i = Convert.ToInt32(f); // Convert Class
        //Now the i will print the value as "123" instead of 123.45.. As there was a loss of information complier did not do implicit conversion.

        //Difference between Type Cast Operator and Class Convert
        float f = 124234324324324324.45F;
        int i = (int)f; //Here the i will show the maximum number of value that int can hold, something like: -2147483648.
        int i = Convert.ToInt32(f); //It will throw an exception "Value was either too large or too small for an Int32.

        //3.Parse() and TryParse()
    }
}

