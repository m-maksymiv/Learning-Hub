namespace CSharpFundamentals;

/// <summary>
/// Control Flow
/// </summary>
public static class Section3
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public static void Run()
    {
        IfElseAndSwitchCase();
        ForLoops();
        ForeachLoops();
        WhileLoops();
        RandomClass();
    }

    private static void IfElseAndSwitchCase()
    {
        Console.WriteLine("Start -> If\\Else and Switch\\Case");

        int hour = 10;

        if (hour > 0 && hour < 12)
            Console.WriteLine("It's morning."); //Output: It's morning.
        else if (hour >= 12 && hour < 18)
            Console.WriteLine("It's afternoon.");
        else
            Console.WriteLine("It's evening.");

        bool isGoldCustomer = true;
        float price;

        if (isGoldCustomer)
            price = 19.95f;
        else
            price = 29.95f;

        Console.WriteLine(price); //Output: 19.95

        float cost = isGoldCustomer ? 12.45f : 15.32f;
        Console.WriteLine(cost); //Output: 12.45f

        var season = Season.Autumn;

        switch (season)
        {
            case Season.Autumn:
                Console.WriteLine("It's autumn and a beautiful seasen."); //Output: It's autumn and a beautiful seasen.
                break;

            case Season.Summer:
                Console.WriteLine("It`s perfect to go to beach.");
                break;

            default:
                Console.WriteLine("I don't understand that season!");
                break;
        }

        Console.WriteLine("Finish -> If\\Else and Switch\\Case");
    }

    private static void ForLoops()
    {
        Console.WriteLine("Start ->  For Loops");

        for (var i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i); //Output: 2 4 6 8 10
            }
        }

        for (var i = 10; i >= 1; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i); //Output: 10 8 6 4 2
            }
        }
        Console.WriteLine("Finish ->  For Loops");
    }

    private static void ForeachLoops()
    {
        Console.WriteLine("Start -> Foreach Loops");

        var name = "Mykola Maksymiv";

        //for (int i = 0; i < name.Length; i++)
        //{
        //    Console.WriteLine(name[i]);
        //}

        foreach (var character in name)
        {
            Console.WriteLine(character); // Output: M y k o l a   M a k s y m i v
        }

        var numbers = new int[] { 1, 2, 3, 4, 5 };

        foreach (var number in numbers)
        {
            Console.WriteLine(number); //Output: 1 2 3 4 5
        }

        Console.WriteLine("Start -> Foreach Loops");
    }

    private static void WhileLoops()
    {
        Console.WriteLine("Start -> While Loops");

        while (true)
        {
            Console.WriteLine("Type  your name");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                break;

            Console.WriteLine("@Echo:" + input);
        }

        Console.WriteLine("Finish -> While Loops");
    }

    private static void RandomClass()
    {
        Console.WriteLine("Start -> Random class");

        var random = new Random();

        const int passwordLength = 10;

        var buffer = new char[passwordLength];

        for (int i = 0; i < passwordLength; i++)
            buffer[i] = (char)('a' + random.Next(0, 26));

        var password = new string(buffer);

        Console.WriteLine(password); //Output: random string

        Console.WriteLine("Finish -> Random class");
    }

    public static void Exercises()
    {
        Console.WriteLine("Start -> Exercises");

        Task1();
        Task2();
        Task3();
        Task4();
        Task5();

        Console.WriteLine("Finish -> Exercises");
    }

    /// <summary>
    /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
    /// Display the count on the console 
    /// </summary>
    private static void Task1()
    {
        int count = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
                count++;
        }

        Console.WriteLine("The count of numbers between 1 and 100 that are divisible by 3 is: {0}", count);
    }

    /// <summary>
    /// Write a program and continuously ask the user to enter a number or "ok" to exit.
    /// Calculate the sum of all the previously entered numbers and display it on the console.
    /// </summary>
    private static void Task2()
    {
        var stopKey = "OK";
        var sum = 0;

        while (true)
        {
            Console.WriteLine("Enter a number (or type 'ok' to exit):");
            var input = Console.ReadLine();

            if (input?.ToLower() == stopKey.ToLower())
                break;

            if (int.TryParse(input, out int number))
                sum += number;
            else
                Console.WriteLine("Invalid input. Please enter a valid number or 'ok' to exit.");
        }

        Console.WriteLine($"The sum of all entered numbers is: {sum}");
    }

    /// <summary>
    /// Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
    /// For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
    /// </summary>
    private static void Task3()
    {
        Console.WriteLine("Enter a number to calculate its factorial:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 0)
        {
            long factorial = 1;

            for (int i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine($"{number}! = {factorial}");
        }
        else
        {
            Console.WriteLine("Please enter a valid non-negative integer.");
        }
    }

    /// <summary>
    /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
    /// If the user guesses the number, display “You won"; otherwise, display “You lost".
    /// (To make sure the program is behaving correctly, you can display the secret number on the console first.)
    /// </summary>
    private static void Task4()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 11); // Random number between 1 and 10
        int attempts = 4;
        bool isGuessed = false;

        Console.WriteLine($"(Debug Info: The secret number is {secretNumber})"); // Debugging purpose only

        Console.WriteLine("Guess the number (between 1 and 10):");

        for (int i = 0; i < attempts; i++)
        {
            Console.Write($"Attempt {i + 1}/{attempts}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                if (guess == secretNumber)
                {
                    Console.WriteLine("You won!");
                    isGuessed = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong guess, try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            }
        }

        if (!isGuessed)
            Console.WriteLine("You lost! Better luck next time.");
    }

    /// <summary>
    /// Write a program and ask the user to enter a series of numbers separated by comma.
    /// Find the maximum of the numbers and display it on the console. For example,
    /// if the user enters “5, 3, 8, 1, 4", the program should display 8.
    /// </summary>
    private static void Task5()
    {
        Console.WriteLine("Enter a series of numbers separated by commas (e.g., 5,3,8,1,4):");
        string input = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input))
        {
            try
            {
                var numbers = input.Split(',')
                                   .Select(number => int.Parse(number.Trim()))
                                   .ToList();

                int maxNumber = numbers.Max();

                Console.WriteLine($"The maximum number is: {maxNumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numbers separated by commas.");
            }
        }
        else
        {
            Console.WriteLine("Input cannot be empty. Please try again.");
        }
    }
}
