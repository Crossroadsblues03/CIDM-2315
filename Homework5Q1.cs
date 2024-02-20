namespace Homework5Q1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input two integers.");
        
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        
        int largest = QuestionOne(a,b);

        
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {largest}");

    }
    static int QuestionOne(int a, int b){
        if(a>b){
            return a;
        }
        else{
            return b;
        }
        
    }
}
