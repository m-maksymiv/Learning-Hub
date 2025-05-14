namespace CSharpFundamentals;

/// <summary>
/// Primitive Types and Expressions
/// </summary>
public static class Section1
{
    public static void Run()
    {
        VariablesAndConstants();
        TypeConversion();
        Operators();
    }

    private static void VariablesAndConstants()
    {
        Console.WriteLine("Start -> Variables and Constants");

        byte number = 2;
        int count = 10;
        float totalPrice = 20.95f;
        char character = 'A';
        string firstName = "Mykola";
        bool isWorking = true; //false

        Console.WriteLine(number); //Output: 2
        Console.WriteLine(count); //Output: 10
        Console.WriteLine(totalPrice); //Output: 20.95
        Console.WriteLine(character); //Output: A
        Console.WriteLine(firstName); //Output: Mykola
        Console.WriteLine(isWorking); //Output: true

        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //Output: 0 255
        Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); //Output: -3.4028235E+38 3.4028235E+38

        const float Pi = 3.14f;
        //Pi = 0;

        Console.WriteLine("Finish -> Variables and Constants");
    }

    private static void TypeConversion()
    {
        Console.WriteLine("Start -> Type Conversion");

        byte b = 1;
        int i = b;
        Console.WriteLine(i); //Output: 1

        int i1 = 1000;
        byte b1 = (byte)i1;
        Console.WriteLine(b1);//Output: 232

        var number = "1234";
        int i2 = Convert.ToInt32(number);
        Console.WriteLine(i2); //Output: 1234

        try
        {
            var number1 = "1234";
            byte b2 = Convert.ToByte(number1); //Error
            Console.WriteLine(b2);
        }
        catch (Exception)
        {
            Console.WriteLine("The number could not be converted to a byte."); //Output: The number could not be converted to a byte.
        }

        try
        {
            var str = "true";
            bool b3 = Convert.ToBoolean(str);
            Console.WriteLine(b3); //Output: True
        }
        catch (Exception)
        {
        }

        Console.WriteLine("Finish -> Type Conversion");
    }

    private static void Operators()
    {
        Console.WriteLine("Start -> Operators");

        int a = 10;
        int b = 3;
        int c = 5;

        Console.WriteLine(a + b); //Output: 13
        Console.WriteLine(a / b); //Output: 3
        Console.WriteLine(a / (float)b); //Output: 3.333
        Console.WriteLine(a + b * c); //Output: 25


        Console.WriteLine(a > b); //Output: True
        Console.WriteLine(a == b); //Output: False
        Console.WriteLine(!(a == b)); //Output: True

        Console.WriteLine("Finish -> Operators");
    }
}