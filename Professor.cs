using System.Security.Cryptography;

class Professor{
    public string profName;
    public string classTeach;
    private double Salary;

    public void SetSalary(double salary_amount){
        Salary = salary_amount;
    }

    public double GetSalary()
    {
        return Salary;
    }


    public void PrintProfessorInfo(){
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {GetSalary()}");

    }

    
    
}