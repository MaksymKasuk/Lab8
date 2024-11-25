using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class _3
    {
        delegate T ArithmeticOperation<T>(T a, T b);

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число:");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Некоректне число");
                return;
            }

            Console.WriteLine("Введіть друге число:");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Некоректне число");
                return;
            }

            Console.WriteLine("Оберіть операцію (+, -, *, /):");
            string operation = Console.ReadLine();

            ArithmeticOperation<double> operationDelegate = null;

            if (operation == "+") operationDelegate = Add;
            else if (operation == "-") operationDelegate = Subtract;
            else if (operation == "*") operationDelegate = Multiply;
            else if (operation == "/") operationDelegate = Divide;

            if (operationDelegate == null)
            {
                Console.WriteLine("Некоректна операція");
                return;
            }

            double result = operationDelegate(num1, num2);
            Console.WriteLine($"Результат: {result}");
        }

        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ділення на нуль!");
                return double.NaN;
            }
            return a / b;
        }
    }
}
