using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Threading.Tasks.Dataflow;

namespace Homework8;

class Program
{
    static void Main(string[] args)
    {

        //Test Q1
        int [] int_array = {11,23,31,42,53};
        ArraySum(int_array);



        //
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        //Test Q2.1
        PrintAllOddNumber(array_2d);


        //Test Q.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");


        //Test Q.3
        int[,] Q2_3 = DoubleArray(array_2d);

        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
            Console.Write(num + " ");
        }
    }

    //Q1
    public static void ArraySum(int[] int_array){
        int x;
        x = int_array[0] + int_array[1] + int_array[2] + int_array[3] + int_array[4];

        Console.WriteLine($"The Sum of int_array is: {x}");
    }
    //Q2.1
    public static void PrintAllOddNumber(int[ , ] array_2d){
        foreach(int val in array_2d){
            if(val%2 != 0){
                Console.Write(val+ " ");
            }
        }
    }
    //Q2.2
    public static int ElementSum(int[ , ]array_2d){
        
        int sum = 0;
        foreach(int num in array_2d){
            sum += num;
        }
        return sum;
    }
    //Q3
    public static int [ , ] DoubleArray(int[ , ] array_2d){
        int[] array_2d2 = new int [9];
        for(int idx = 0; idx < 9; idx++){
            array_2d2[idx] = array_2d[idx]*2;
        }
        for(int idx = 0; idx < 9; idx++){
            Console.WriteLine(array_2d2[idx]);
        }    
        
    }
}
