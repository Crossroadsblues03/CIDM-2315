class Student{

    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }

    public double GetGrade(){
        return studentGrade;
    }

    public void PrintStudentInfo(){
        Console.WriteLine($"Student {studentName} enrolls in {classEnroll}, and the grade is: {GetGrade()}");
    }

}