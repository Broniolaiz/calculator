
using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            string operation;

            // Ask for operation until valid or exit
            while (true)
            {
                Console.Write("Choose operation (+,-,*,/,%,=): ");
                operation = Console.ReadLine();

                if (operation == "+" || operation == "-" || operation == "*" ||
                    operation == "/" || operation == "%" || operation == "=")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Operation Used, please try again");
                }
            }

            object result = Calculator(num1, num2, operation);

            if (operation == "=")
            {
                Console.WriteLine("Program terminated.");
                running = false;
            }
            else if (result != null)
            {
                Console.WriteLine("Result: " + result);
            }

            Console.WriteLine();
    
        }
    }
    
    

