namespace Homework2Q2;

class Program
{
    static void Main(string[] args)
    {

        //Code that isssues prompt to enter number
        Console.WriteLine("Please input firtst number:");
        double first_num = Convert.ToInt16(Console.ReadLine()); //Where you input your number, Convert code merged within it

        Console.WriteLine("Please input second number:");
        double sec_num = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input third number");
        double third_num = Convert.ToInt16(Console.ReadLine());

        //nested if statment
        if(first_num<sec_num){
            if(first_num<third_num){
                Console.WriteLine($"The smallest value is: {first_num}");
            }
            else{
                Console.WriteLine($"The smallest value is: {third_num}");
            }
        }
        else{
            if(sec_num<third_num){
                Console.WriteLine($"The smallest value is:{sec_num}");
            }
            else{
                Console.WriteLine($"The smallest value is:{third_num}");
            }
        }


    }
}
