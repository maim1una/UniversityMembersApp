using System;
using System.Xml.Linq;
namespace UniversityMembersApp
{ // 1. الفئة الأساسية العليا (Person)
  public class Person
    { 
        public string Name { get; set; } public string Email { get; set; }





    public Person(string name, string email)
    {
        Name = name;
        Email = email;
        Console.WriteLine("[Constructor] Person created.");
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine($"Name: {Name}, Email: {Email}");
    }
}

// 2. فئة الطالب (Student) ترث من Person
public class Student : Person
{
    public int StudentId { get; set; }
    public double GPA { get; set; }

    public Student(string name, string email, int studentId, double gpa)
        : base(name, email)
    {
        StudentId = studentId;
        GPA = gpa;
        Console.WriteLine("[Constructor] Student created.");
    }

    public void DisplayStudentDetails()
    {
        DisplayBasicInfo();
        Console.WriteLine($"Student ID: {StudentId}, GPA: {GPA}");
    }
}

// 3. فئة الموظف (Employee) ترث من Person
public class Employee : Person
{
    public int EmployeeId { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string email, int employeeId, double salary)
        : base(name, email)
    {
        EmployeeId = employeeId;
        Salary = salary;
        Console.WriteLine("[Constructor] Employee created.");
    }
}

// 4. فئة المدرس (Teacher) ترث من Employee
public class Teacher : Employee
{
    public string CourseName { get; set; }

    public Teacher(string name, string email, int employeeId, double salary, string courseName)
        : base(name, email, employeeId, salary)
    {
        CourseName = courseName;
        Console.WriteLine("[Constructor] Teacher created.");
    }

    public void Teach()
    {
        Console.WriteLine($"Teacher {Name} is teaching {CourseName}.");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Creating Student Object ---");
        // إنشاء كائن طالب وتحديد ترتيب تنفيذ المشيد
        Student student = new Student("Ali", "ali@email.com", 202401, 3.85);

        Console.WriteLine("\n--- Creating Teacher Object ---");
        // إنشاء كائن مدرس وتحديد ترتيب تنفيذ المشيد
        Teacher teacher = new Teacher("Dr. Wafaa", "wafaa@email.com", 1002, 15000, "HCI");

        Console.WriteLine("\n--- Calling Inherited and Specialized Methods ---");

        // استدعاء الدوال للطالب
        Console.WriteLine("\n[Student Information]:");
        student.DisplayStudentDetails();

        // استدعاء الدوال للمدرس
        Console.WriteLine("\n[Teacher Information]:");
        teacher.DisplayBasicInfo(); // دالة موروثة من Person
        teacher.Teach();            // دالة خاصة بكلاس Teacher

        Console.ReadLine();
    }
}
}