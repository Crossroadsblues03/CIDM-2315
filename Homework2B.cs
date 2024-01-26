namespace Homework2B;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a year:");

        double leap_year = Convert.ToInt16(Console.ReadLine());


        //Used Logical Operators to determine what a Leap year and what isn't
        if((leap_year % 4000 == 0)|| (leap_year%100 != 0 && leap_year%4 == 0) ){
            Console.WriteLine($"{leap_year} is a Leap Year.");
        }
        else{
            Console.WriteLine($"{leap_year} is not a Leap Year.");
        }
    }
}
