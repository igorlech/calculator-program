namespace Calculator
{
    class Program
    {


        static void Main(string[] args)
        {
            int num1;
            int num2;

            string answer;

            int result;

            Console.WriteLine("Calculator program");
            Console.WriteLine("Enter first number");

            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);

            Console.WriteLine("Enter second number");

            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2);

            Console.WriteLine("Choose the type of the operation that you would like to perform. Press a for addition, s for substraction, m for multiplication and any other key for division");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Hit any key to quit");

            Console.ReadKey();
        }
    }
}