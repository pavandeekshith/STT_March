using System;

class Student
{
    // Properties
    public string Name { get; set; }
    public int ID { get; set; }
    public double Marks { get; set; }

    // Constructor
    public Student(string name, int id, double marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    // Method to calculate grade
    public string GetGrade()
    {
        if (Marks >= 90) return "A";
        else if (Marks >= 80) return "B";
        else if (Marks >= 70) return "C";
        else if (Marks >= 60) return "D";
        else return "F";
    }
}

class StudentIITGN : Student
{
    public string Hostel_Name_IITGN { get; set; }

    // Constructor for subclass
    public StudentIITGN(string name, int id, double marks, string hostel)
        : base(name, id, marks)
    {
        Hostel_Name_IITGN = hostel;
    }
}

class Program
{
    public static void Main()
    {
        // Base class student
        Student s = new Student("Alice", 101, 85.5);
        Console.WriteLine("=== Student Details ===");
        Console.WriteLine($"Name: {s.Name}");
        Console.WriteLine($"ID: {s.ID}");
        Console.WriteLine($"Marks: {s.Marks}");
        Console.WriteLine($"Grade: {s.GetGrade()}");

        // Subclass student
        StudentIITGN student = new StudentIITGN("Pavan", 2025, 92.3, "Brahmaputra");
        Console.WriteLine("\n=== IITGN Student Details ===");
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"ID: {student.ID}");
        Console.WriteLine($"Marks: {student.Marks}");
        Console.WriteLine($"Grade: {student.GetGrade()}");
        Console.WriteLine($"Hostel: {student.Hostel_Name_IITGN}");
    }
}