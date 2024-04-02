using System.ComponentModel;
using System.Linq;
//found when researching on how to use Sum and System.Linq
using System.Collections.Generic;
using System.Diagnostics;

namespace Homework9;

class Program
{    static void Main(string[] args)
    {
        //Unfinished
        //
        Student Alice = new Student(student_id:111, student_name: "Alice");
        Student Bob = new Student(student_id:222, student_name: "Bob");
        Student Cathy = new Student(student_id:333, student_name: "Cathy");
        Student David = new Student(student_id:444, student_name: "David");

        //Dictionary created to hold GPA
        Dictionary<double, string> stu_info = new Dictionary<double, string>();
        stu_info.Add(4.0, "Alice");
        stu_info.Add(3.6, "Bob");
        stu_info.Add(2.5, "Cathy");
        stu_info.Add(1.8, "David");
    
        //if statement to determine Tom's inclusion in list
        if(stu_info.ContainsValue("Tom")){
            Console.WriteLine("Nice");
        }
        else{
            stu_info.Add(3.3, "Tom");
        }

        //Got help from chatgpt
        //ChatGPT, 2024, April 1, "how to calculate the average key in a Dictionary in C#"
        double average_gpa = stu_info.Keys.Average();
        Console.WriteLine($"The average GPA is: {average_gpa}");

        //could not figure out how to 
        
        //foreach to display Print Info
        foreach(Student stu in Student.student_list){
            stu.PrintInfo();
        }
        
    }
}
class Student
{
    private int studentID;
    private string studentName;
    public void PrintInfo(){
        
    }
    public static List<Student> student_list = new List<Student>();
    //constructor for Student
    public Student(int student_id, string student_name){
        studentID = student_id;
        studentName = student_name;
        student_list.Add(this);
    }
}
