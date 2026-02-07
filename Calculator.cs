using System;

public static class Calculator
{
    public static double? Calculate(int first, int second, string operation)
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
        

        return null;
    }
}

