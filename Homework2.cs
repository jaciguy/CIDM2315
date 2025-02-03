namespace Homework2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int smallest = num1;

            if (num2 < smallest)
            {
                smallest = num2;
            }

            if (num3 < smallest)
            {
                smallest = num3;
            }

            Console.WriteLine("The smallest value is: " + smallest);
        }
    }
}
    

