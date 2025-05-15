namespace CSharpFundamentals.Sections;

/// <summary>
/// Non-Primitive Types
/// </summary>
public static class Section2
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    public class Calcularor
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }

    public static void Run()
    {
        Class();
        Arrays();
        Strings();
        Enums();
        ReferenceTypesAndValueTypes();
    }

    private static void Class()
    {
        Console.WriteLine("Start -> Class");

        var person = new Person();

        person.FirstName = "Mykola";
        person.LastName = "Maskymiv";
        person.Introduce(); //Output: My name is Mykola Maksymiv

        var calcularor = new Calcularor();

        var result = calcularor.Add(1, 2);
        Console.WriteLine(result); //Output: 3

        Console.WriteLine("Finish -> Class");
    }

    private static void Arrays()
    {
        Console.WriteLine("Start -> Arrays");

        var numbers = new int[3];
        numbers[0] = 1;

        Console.WriteLine(numbers[0]); //Output: 1
        Console.WriteLine(numbers[1]); //Output: 0
        Console.WriteLine(numbers[2]); //Output: 0

        var flags = new bool[3];
        flags[0] = true;

        Console.WriteLine(flags[0]); //Output: True
        Console.WriteLine(flags[1]); //Output: False
        Console.WriteLine(flags[2]); //Output: False

        var names = new string[3] { "Jack", "John", "Mary" };

        Console.WriteLine(names[0]); //Output: Jack

        Console.WriteLine("Finish -> Arrays");
    }

    private static void Strings()
    {
        Console.WriteLine("Start -> Strings");

        var firstName = "Mykola";
        var lastname = "Maksymiv";

        var fullName = firstName + " " + lastname;

        var myFullName = string.Format("My name is {0} {1}", firstName, lastname);

        Console.WriteLine(myFullName); // Output: My name is Mykola Maksymiv

        var names = new string[3] { "Jack", "John", "Mary" };

        var formattedNames = string.Join(", ", names);

        Console.WriteLine(formattedNames); //Output: Jack, John, Mary

        var text = "Hi Mykola\nLook into the following paths \nc:\\forler1\\folder2";
        var text1 = @"Hi Mykola 
                         Look into the following paths
                         c:\forler1\folder2";

        Console.WriteLine(text);//Output: Hi Mykola Look into the following paths c:\\forler1\\folder2
        Console.WriteLine(text1); //Output: Hi Mykola            Look into the following paths       c:\\forler1\\folder2"

        Console.WriteLine("Finish -> Strings");
    }

    private static void Enums()
    {
        Console.WriteLine("Start -> Enums");

        var method = ShippingMethod.Express;
        Console.WriteLine((int)method); //Output: 3

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId); //Output: Express

        Console.WriteLine(method.ToString());  //Output: Express

        var methodName = "Express";

        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        Console.WriteLine("Finish -> Enums");
    }

    private static void ReferenceTypesAndValueTypes()
    {
        Console.WriteLine("Start -> Reference Types and Value Types");

        var a = 10;
        var b = a;
        b++;

        Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); //Output a : 10, b: 11

        var array1 = new int[3] { 1, 2, 3 };
        var array2 = array1;
        array2[0] = 0;

        Console.WriteLine(string.Format("array1[0]: {0}, array[0] : {1}", array1[0], array2[0])); //Output: "array1[0]: 0, array[0] : 0

        var number = 1;
        Increment(number);
        Console.WriteLine(number); //Output: 1

        var person = new Person() { Age = 20 };
        MakeOld(person);
        Console.WriteLine(person.Age);  //Output: 30

        Console.WriteLine("Finish -> Reference Types and Value Types");
    }

    private static void Increment(int number)
    {
        number += 10;
    }

    private static void MakeOld(Person person)
    {
        person.Age += 10;
    }
}
