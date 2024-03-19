using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        float nr1;
        float nr2;
        float res = 0;
        string choice;
        Console.WriteLine("Calculator");
        Start:
        Console.WriteLine("\nOperation?");
        Console.WriteLine("1 for addition.");
        Console.WriteLine("2 for substraction.");
        Console.WriteLine("3 for multiplication.");
        Console.WriteLine("4 for division.");
        Console.WriteLine("5 to exit.");
        Console.Write("choice: ");
        choice = Console.ReadLine();
        
            if (choice == "1")
            {
                Console.Write("Enter 1st number: ");
                nr1 = Convert.ToInt32(Console.ReadLine());
        
                Console.Write("Enter 2nd number: ");
                nr2 = Convert.ToInt32(Console.ReadLine());
                res = nr1 + nr2;

            }
            else if (choice == "2")
            {
                Console.Write("Enter 1st number: ");
                nr1 = Convert.ToInt32(Console.ReadLine());
        
                Console.Write("Enter 2nd number: ");
                nr2 = Convert.ToInt32(Console.ReadLine());
                res = nr1 - nr2;
            }
            else if (choice == "3")
            {
                Console.Write("Enter 1st number: ");
                nr1 = Convert.ToInt32(Console.ReadLine());
        
                Console.Write("Enter 2nd number: ");
                nr2 = Convert.ToInt32(Console.ReadLine());
                res = nr1 * nr2;
            }
            else if (choice == "4")
            {
                Console.Write("Enter 1st number: ");
                nr1 = Convert.ToInt32(Console.ReadLine());
        
                Console.Write("Enter 2nd number: ");
                nr2 = Convert.ToInt32(Console.ReadLine());
                res = nr1 / nr2;
            }
            else if (choice == "5")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Write("Wrong choice!");
            }
            
        Console.WriteLine("Result: "+ res);
        goto Start;
        
        Console.ReadKey();
        
    }
}