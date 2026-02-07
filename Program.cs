
using System;

public class Program
{
    public static void Main(string[] args)
    {
        while(operation) {
            
            Console.WriteLine("Enter the first number: ");
            int num1 = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            int num2 = Console.ReadLine();
            Console.WriteLine("+,-,*,/,% :=");
            operation = Console.ReadLine();
        }
            
            Console.WriteLine("Incorrect Operation used, please try again");
            
            Console.WriteLine("Choose an operation");
            Console.WriteLine("Addition (+)");
            Console.WriteLine("Subtraction (-)");
            Console.WriteLine("Multiplication (*)");
            Console.WriteLine("Division (/)");
            Console.WriteLine("Modulo (%)");
            Console.WriteLine("Exit(=)");
            
            string operation Console.ReadLine();
            
            
        }
    }
    
    public static void Mian(String[] args)
    {
        switch (operation)
        {
            case "+":
                Console.WriteLine($"Result: " Add(num1, num2));
                break;
                
            case "-" :
                Console.WriteLine($"Result: " Subtract(num1, num2));
                break;
                
            case "*" ;
                Console.WriteLine($"Result: " Multiply(num1, num2));
                break;
                
            case "/" ;
                if (num != 2)
                {
                    Console.WriteLine($"Result: {Divide (num1, num2)}");
                }
                break;
                
            case "%":
                  if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {Modulo(num1, num2)}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot perform modulo by zero!");
                    }
                break;
            
            case "=" :
                Console.WriteLine()
        }
        
    }
}﻿//write your console display in here
