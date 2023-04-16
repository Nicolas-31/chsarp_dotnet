namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("Hello!");
                Console.WriteLine("Input the first number:");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Input the second number:");

                double secondNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("What do you want to do?");

                Console.WriteLine("[A]dd numbers");
                Console.WriteLine("[S]ubstract numbers");
                Console.WriteLine("[M]ultiply numbers");
                Console.WriteLine("[D]ivide numbers");
                Console.WriteLine("[Q]uit the program");

                var operationChoice = Console.ReadLine();

                if (EqualsCaseInsensitive(operationChoice, "A"))
                {
                    var sum = firstNumber + secondNumber;

                    PrintFinalResult(firstNumber, secondNumber, sum, "+");
                }
                else if (EqualsCaseInsensitive(operationChoice, "S"))
                {
                    var difference = firstNumber - secondNumber;
                    PrintFinalResult(firstNumber, secondNumber, difference, "-");
                }
                else if (EqualsCaseInsensitive(operationChoice, "M"))
                {
                    var multiplied = firstNumber * secondNumber;
                    PrintFinalResult(firstNumber, secondNumber, multiplied, "*");
                }
                else if (EqualsCaseInsensitive(operationChoice, "D"))
                {
                    var divided = firstNumber / secondNumber;
                    PrintFinalResult(firstNumber, secondNumber, divided, "/");
                }
                else if (EqualsCaseInsensitive(operationChoice, "Q"))
                {
                    run = false;
                    Console.WriteLine("Press any key to close ");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }

        private static void PrintFinalResult(double firstNumber, double secondNumber, double result, string @operator)
        {
            Console.WriteLine(firstNumber + " " + @operator + " " + secondNumber + " = " + result);
        }

        private static bool EqualsCaseInsensitive(string left, string right)
        {
            return left.ToUpper() == right.ToUpper();
        }
    }
   
}