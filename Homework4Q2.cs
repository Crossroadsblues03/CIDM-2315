namespace Homework4Q2;

class Program
{
    static void Main(string[] args)
    {
        string shape;
        
        Console.WriteLine("Please input a integer and shape: ");
        int N = Convert.ToInt16(Console.ReadLine());
        shape = Console.ReadLine();
        Console.WriteLine($"N is {N}; shape is {shape}");

        QuestionTwo(N, shape); 
    }

    static void QuestionTwo(int N, string shape)
    {
        
        //if and else if statement used for prompt
        if(shape == "left"){
            //nested loop used for left shaped, from example shown in slides
            for(int row = 0; row < N; row++){
                for(int col = 0; col < N; col++)
                {
                    if(row>=col)
                    Console.Write('*');
                }
                Console.WriteLine("");
            }
        }
        //example provided by you that helped
        else if(shape == "right"){
            for (int i = 1; i <= N; i++)
            {
            //help calculate the blank spaces for row
            for (int j = N - i; j >= 1; j--) 
            {
                Console.Write(" ");
            }
            //to calculate the # of stars
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            //used to help spacing
            Console.WriteLine("");
            }
        }
    }
    
}
