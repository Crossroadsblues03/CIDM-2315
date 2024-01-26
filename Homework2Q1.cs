namespace Homework2;

class Program
{
    static void Main(string[] args)
    {

        //Used to input letter grade
        Console.WriteLine("Please input a letter grade: ");


        string letter = Console.ReadLine();


        //if else if statement used
        if (letter == "A"){
            Console.WriteLine($"Gpa point: 4");
        }
        else if(letter == "B"){
            Console.WriteLine($"Gpa point: 3");
        }
        else if(letter == "C"){
            Console.WriteLine($"Gpa point: 2");
        }
        else if(letter == "D"){
            Console.WriteLine($"Gpa point: 1");
        }
        else if(letter == "F"){
            Console.WriteLine($"Gpa point: 0");
        }
        else{
            Console.WriteLine("Wrong letter grade!");
        }

    }
}
