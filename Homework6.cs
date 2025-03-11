using System;

namespace CombinedHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Homework 1
            double X = 2.5;
            double Y = 3.3;
            double Z = 4 * X * X + 3 * Y;
            Console.WriteLine($"The value of Z for X = {X} and Y = {Y} is: {Z}");

            // Homework 2
            Console.WriteLine("Enter a grade (A, B, C, D, F):");
            string grade = Console.ReadLine().ToUpper();
            switch (grade)
            {
                case "A":
                    Console.WriteLine("GPA: 4");
                    break;
                case "B":
                    Console.WriteLine("GPA: 3");
                    break;
                case "C":
                    Console.WriteLine("GPA: 2");
                    break;
                case "D":
                    Console.WriteLine("GPA: 1");
                    break;
                case "F":
                    Console.WriteLine("GPA: 0");
                    break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    break;
            }

            // Smallest number
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int smallest = num1;
            if (num2 < smallest) smallest = num2;
            if (num3 < smallest) smallest = num3;
            Console.WriteLine("The smallest value is: " + smallest);

            // Prime number check
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is prime");
            }
            else
            {
                Console.WriteLine($"{number} is non-prime");
            }

            // Square pattern
            Console.Write("Enter the value of N for square pattern: ");
            int N = int.Parse(Console.ReadLine());
            PrintSquarePattern(N);

            // Conditional square pattern
            Console.Write("Enter the value of N for conditional square pattern: ");
            int M = int.Parse(Console.ReadLine());
            PrintNumberPattern(M);

            // Bonus square pattern
            Console.Write("Enter the value of N for bonus pattern: ");
            int P = int.Parse(Console.ReadLine());
            PrintBonusSquarePattern(P);

            // Largest number
            Console.WriteLine("Enter the first number:");
            if (!int.TryParse(Console.ReadLine(), out int number1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            Console.WriteLine("Enter the second number:");
            if (!int.TryParse(Console.ReadLine(), out int number2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            int largest = GetLargestNumber(number1, number2);
            Console.WriteLine($"The largest number is: {largest}");

            // Triangle pattern
            Console.WriteLine("Enter the value of N:");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            Console.WriteLine("Enter the shape (left or right):");
            string? shape = Console.ReadLine();
            if (string.IsNullOrEmpty(shape))
            {
                Console.WriteLine("Invalid shape input. Please enter 'left' or 'right'.");
                return;
            }
            PrintTriangle(n, shape);

            // Largest of four numbers
            Console.WriteLine("Enter a number:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a third number:");
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a fourth number:");
            int num7 = Convert.ToInt32(Console.ReadLine());
            int largestQ2 = GetLargestOfFour(num4, num5, num6, num7);
            Console.WriteLine($"a={num4}, b={num5}, c={num6}, d={num7}");
            Console.WriteLine("The largest number is: " + largestQ2);

            // Create account
            createAccount();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void PrintSquarePattern(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintNumberPattern(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintBonusSquarePattern(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < N - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        static int GetLargestNumber(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        static void PrintTriangle(int N, string shape)
        {
            Console.WriteLine($"N: {N}, Shape: {shape}");
            if (shape.ToLower() == "left")
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (shape.ToLower() == "right")
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= N - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid shape. Please choose 'left' or 'right'.");
            }
        }

        static int GetLargestOfFour(int a, int b, int c, int d)
        {
            int max1 = GetLargestNumber(a, b);
            int max2 = GetLargestNumber(c, d);
            return GetLargestNumber(max1, max2);
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
}
