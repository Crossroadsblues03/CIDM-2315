namespace Homework5Q3;

class Program
{
    static void Main(string[] args)
    {

        //undfinsihed
        createAccount();
    }

    static bool checkAge(int birth_year){

        int age = 2024 - birth_year;
        if(age >= 18){
            return true;
        }
        else{
            return false;
        }
    }

    static void createAccount(){
        Console.WriteLine("Please input Username:");
        Console.ReadLine();

        Console.WriteLine("Please input password:");
        string password_one = Console.ReadLine();

        Console.WriteLine("Please input password again:");
        string password_two = Console.ReadLine();

        Console.WriteLine("Please input birthyear");
        int birth_year = Convert.ToInt16(Console.ReadLine());

        checkAge(birth_year);

        

        if(password_one == password_two){
            Console.WriteLine("Account was created successfully");
        }
        else{
            Console.WriteLine("Wrong password");
        }



    }
}
