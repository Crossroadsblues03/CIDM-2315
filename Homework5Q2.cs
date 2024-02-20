namespace Homework5Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input four integers.");
        
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        int c = Convert.ToInt16(Console.ReadLine());
        int d = Convert.ToInt16(Console.ReadLine());
        
        int MaxOne = LargestOne(a,b);
        int MaxTwo = LargestTwo(c,d);
        int MaxLargest = MaxLarge(MaxOne, MaxTwo);


        
        Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}");
        Console.WriteLine($"The largest number is: {MaxLargest}");
    }

    static int LargestOne(int a, int b){
        if(a>b){
            return a;
        }
        else{
            return b;
        }
        
    }
    static int LargestTwo(int c, int d){
        if(c>d){
            return c;
        }
        else{
            return d;
        }
        
    }
    static int MaxLarge(int MaxOne, int MaxTwo){
        if (MaxOne>MaxTwo){
            return MaxOne;
        }
        else{
            return MaxTwo;
        }
    }


}
