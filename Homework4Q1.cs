namespace Homework4Q1;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        

        //Used as prompt for users to answer
        Console.WriteLine("Please input two numbers");

        //Code below used to convert integer.
        a = Convert.ToInt16(Console.ReadLine());
        b = Convert.ToInt16(Console.ReadLine());

        //Code to display two integers
        Console.WriteLine($"a = {a}; b = {b}");
        //Method call
        QuestionOne(a,b);
    }

    static void QuestionOne(int a, int b)
    {
        if(a>b)
        {
            Console.WriteLine($"{a} is the largest number.");
        }
        else
        {
            Console.WriteLine($"{b} is the largest number.");
        }
    }
}
