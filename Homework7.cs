using System.Net.Mail;
using System.Reflection.Metadata;

namespace Homework7;

class Program
{
    static void Main(string[] args)
    {  
        //Customer info for Constructor
        Customer Alice = new Customer(input_id: 110, input_age:28 ,input_name:"Alice" );
        Alice.PrintCusInfo();
        
        //Customer Info for Constructor 
        Customer Bob = new Customer(input_id: 111, input_age:30, input_name:"Bob");
        Bob.PrintCusInfo();

        //Used to change ID, as well as print changes
        Alice.ChangeID(220);
        Alice.PrintCusInfo();

        //Used to change ID,as well as print changes
        Bob.ChangeID(221);
        Bob.PrintCusInfo();

        //Print Method to compare ages of Customers
        Alice.CompareAge(Alice);

    }
}
class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;
    public Customer(int input_id, string input_name, int input_age)
    {
        cus_id = input_id;
        cus_name = input_name;
        cus_age = input_age;

        //Used for CompareAge
        this.cus_age = cus_age;
        

    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;

    }
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }
    public void CompareAge(Customer objCustomer)
    {
        if(this.cus_age > objCustomer.cus_age){
            Console.WriteLine($"Alice is older.");
        }
        else{
            Console.WriteLine($"Bob is older.");
        }
    }
    
}