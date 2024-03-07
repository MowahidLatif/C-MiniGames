namespace Calculator;

class Program
{
    static void Main(string[] args)
    {

        int num1;
        int num2;
        string operation;
        int result;
        Console.WriteLine("Welcome to the Calculator Program!");
        Console.WriteLine("Please enter the first number: ");

        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your first number is " + num1);

        Console.WriteLine("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your second number is " + num2);

        Console.WriteLine("Please enter the operation (+, -, *, /): ");
        operation = Console.ReadLine();
        Console.WriteLine("Your chosen operation is " + operation);

        if (operation == "+") {
            result = num1 + num2;
        } else if (operation == "-") {
            result = num1 - num2;
        } else if (operation == "*") {
            result = num1 * num2;
        } else {
            result = num1 / num2;
        }

        System.Console.WriteLine("Your Answer is: " + result);

        Console.ReadKey();
    }
}
