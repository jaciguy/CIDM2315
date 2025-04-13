using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
    }

    public string GetName() => studentName; 
}

class Program
{
    static void Main()
    {
        
        new Student(111, "Alice");
        new Student(222, "Bob");
        new Student(333, "Cathy");
        new Student(444, "David");

        
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        
        double averageGPA = gradebook.Values.Average();
        Console.WriteLine($"Average GPA: {averageGPA:F2}");

        
        Console.WriteLine("Students with GPA greater than the average:");
        foreach (var student in Student.studentList)
        {
            string studentName = student.GetName(); 
            if (gradebook.ContainsKey(studentName) && gradebook[studentName] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}


