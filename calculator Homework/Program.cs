using System;

class Program
{
    static void Main()
    {
        Console.Title = "Calculator Homework";



        Console.WriteLine("Wellcome In My Calculator!");

        while (true)
        {
            Console.Write("Please enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the arithmetic operation (+, -, *, /) or 'e' to exit:");
            string operation = Console.ReadLine();

            if (operation == "e")
                break;

            Console.Write("Please enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    continue;
            }

            Console.WriteLine("result: " + result);
        }

        Console.WriteLine("Thank you for using the simple calculator.Press any key to exit.");
        Console.ReadKey();
    }
}


