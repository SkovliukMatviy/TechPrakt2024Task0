using System;
using System.Globalization;
using System.Text;

class Calculator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть перше число:");
        double number1 = GetValidatedInput();

        Console.WriteLine("Введіть друге число:");
        double number2 = GetValidatedInput();

        double sum = CalculateSum(number1, number2);

     
        Console.WriteLine($"Сума чисел {number1} і {number2} дорівнює: {sum.ToString("N0")}"); 

        Console.ReadLine(); 
    }

    static double GetValidatedInput()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некоректний ввід. Будь ласка, введіть число коректно:");
        }
        return number;
    }

    static double CalculateSum(double num1, double num2)
    {
        return num1 + num2;
    }
}
