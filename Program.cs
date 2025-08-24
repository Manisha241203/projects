using System;
namespace calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool calculate = true;
            while (calculate)
            {
                double num1;
                double num2;
                char Operator;
               
                Console.WriteLine("Welcome to Calculator");
                Console.WriteLine("Enter your number ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Operator");
                Operator = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter another number");
                num2 = Convert.ToDouble(Console.ReadLine());
                double total = 0;

                switch (Operator)
                {
                    case '+':
                        total = num1 + num2; break;

                    case '-':
                        total = num1 - num2; break;

                    case '*':
                        total = num1 * num2; break;

                    case '/':

                        if (num2 == 0)
                        {
                            Console.WriteLine("can not divided by zero");
                        }
                        else
                        {
                            total = num1 / num2;
                        }
                        break;

                    default:

                        Console.WriteLine("invalid Operator");
                        break;

                }
                Console.WriteLine("Total : " + total.ToString());

                Console.WriteLine("Want to continue? press Y to continue and C to close ");
                char restart = Convert.ToChar(Console.ReadLine());
                switch (restart)
                {
                    case 'Y':
                        continue;
                    case 'C':
                        calculate = false;
                        Console.WriteLine("Calculator Closed. Bye");
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Closing Calculator.");
                        break;
                }

                
            }
        }
    }
}
