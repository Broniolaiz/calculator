using System;

public static class Calculator
{
    public static double? Calculate(int first, int second, string operation)
    {
         switch (op)
        {
            case "+":
                return a + b;

            case "-":
                return a - b;

            case "*":
                return a * b;

            case "/":
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return null;
                }
                return Math.Round((double)a / b, 2);

            case "%":
                if (b == 0)
                {
                    Console.WriteLine("Cannot modulo by zero");
                    return null;
                }
                return a % b;

            case "=":
                return null;

             default:

        return null;
    }
}

