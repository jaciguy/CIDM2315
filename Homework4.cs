using System;

class Program
{
    static void Main(string[] args)
    {
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
        
        Console.WriteLine("Enter the value of N:");
        if (!int.TryParse(Console.ReadLine(), out int N))
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

        PrintTriangle(N, shape);
    }

    static int GetLargestNumber(int num1, int num2)
    {
        if (num1 > num2)
            return num1;
        else
            return num2;
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
}






