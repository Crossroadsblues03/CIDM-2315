using System.Globalization;

namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //
        Professor p1 = new Professor();
        p1.profName= "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        p1.PrintProfessorInfo();

        //
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        p2.PrintProfessorInfo();

        //
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        s1.PrintStudentInfo();

        //
        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        s2.PrintStudentInfo();

        //
        Console.WriteLine($"The salary difference between Alice and Bob is: {p1.GetSalary() - p2.GetSalary()}");

        //
        Console.WriteLine($"The total grade of Lisa and Tome is: {s1.GetGrade() + s2.GetGrade()}");

    }

}
