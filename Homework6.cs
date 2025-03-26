using System;

class Professor
{
    public string ProfName { get; set; }
    public string ClassTeach { get; set; }
    private double salary;

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Student
{
    public string StudentName { get; set; }
    public string ClassEnroll { get; set; }
    private double studentGrade;

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating Professors
        Professor prof1 = new Professor { ProfName = "Alice", ClassTeach = "Java" };
        prof1.SetSalary(9000);

        Professor prof2 = new Professor { ProfName = "Bob", ClassTeach = "Math" };
        prof2.SetSalary(8000);

        // Creating Students
        Student student1 = new Student { StudentName = "Lisa", ClassEnroll = "Java" };
        student1.SetGrade(90);

        Student student2 = new Student { StudentName = "Tom", ClassEnroll = "Math" };
        student2.SetGrade(80);

        // Printing Professor Details
        Console.WriteLine($"Professor {prof1.ProfName} teaches {prof1.ClassTeach}, and the salary is: {prof1.GetSalary()}");
        Console.WriteLine($"Professor {prof2.ProfName} teaches {prof2.ClassTeach}, and the salary is: {prof2.GetSalary()}");

        // Printing Student Details
        Console.WriteLine($"Student {student1.StudentName} is enrolled in {student1.ClassEnroll}, and their grade is: {student1.GetGrade()}");
        Console.WriteLine($"Student {student2.StudentName} is enrolled in {student2.ClassEnroll}, and their grade is: {student2.GetGrade()}");

        // Calculating and Printing Differences and Totals
        double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine($"Difference in Salary between Professors: {salaryDifference}");

        double totalGrades = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"Total Grades of Lisa and Tom is: {totalGrades}");
    }
}

