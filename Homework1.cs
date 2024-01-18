namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        //input info that was provided
        //float needed for decimals
        float x = 2.5f;
        float y = 3.3f;

        //z is used for the formula
        //used parentheses to ensure formula did it in order
        float z = (4 * x * x) + 3 * y;


        //Code used to print out the output of the formula.
        Console.WriteLine($"X = 2.5, \t Y = 3.3 \nThe value of Z is: {z}");

    }
}
