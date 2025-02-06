using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1
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

            // Q2
            Console.Write("Enter the value of N for square pattern: ");
            int N = int.Parse(Console.ReadLine());

            PrintSquarePattern(N);

            // Q3
            Console.Write("Enter the value of N for conditional square pattern: ");
            int M = int.Parse(Console.ReadLine());

            PrintNumberPattern(M);

            // BQ
            Console.Write("Enter the value of N for bonus pattern: ");
            int P = int.Parse(Console.ReadLine());

            PrintBonusSquarePattern(P);
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
    }
}




        
