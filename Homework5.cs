using System;

class Program
{
    static void Main(string[] args)
    {
        // Q1
        Console.WriteLine("Enter a number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int largestQ1 = GetLargest(num1, num2);
        Console.WriteLine($"a={num1}, b={num2}");
        Console.WriteLine("The largest number is: " + largestQ1);

        // Q2
        Console.WriteLine("Enter a number:");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second number:");
        int num4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a third number:");
        int num5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a fourth number:");
        int num6 = Convert.ToInt32(Console.ReadLine());
        int largestQ2 = GetLargestOfFour(num3, num4, num5, num6);
        Console.WriteLine($"a={num3}, b={num4}, c={num5}, d={num6}");
        Console.WriteLine("The largest number is: " + largestQ2);

        // Q3
        createAccount();
    }

    static int GetLargest(int a, int b)
    {
        return a > b ? a : b;
    }

    static int GetLargestOfFour(int a, int b, int c, int d)
    {
        int max1 = GetLargest(a, b);
        int max2 = GetLargest(c, d);
        return GetLargest(max1, max2);
    }

    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.WriteLine("Enter your username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();

        Console.WriteLine("Enter your password again:");
        string confirmPassword = Console.ReadLine();

        Console.WriteLine("Enter your birth year:");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}


