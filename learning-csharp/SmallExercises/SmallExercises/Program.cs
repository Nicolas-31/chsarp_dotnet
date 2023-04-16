internal class Program
{
    // For loop - Factorial
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer number");
        var userInput = int.Parse(Console.ReadLine());
        Console.WriteLine("The factorial of entered number is " + Factorial(userInput));
        Console.WriteLine("press any key to exist the program");
        Console.ReadKey();
    }


    public static int Factorial(int number)
    {
        int factorial = 1; 
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }


}