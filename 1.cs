using System;


namespace Lab8
{
    internal class Program
    {
        delegate double Function(double x);

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число x:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Потрібно було ввести число");
                return;
            }

            if (!double.TryParse(input, out double x))
            {
                Console.WriteLine("Введено некоректне значення");
                return;
            }

            Function func;

            if (x < 0)
            {
                func = F1;
            }
            else if (x > 0)
            {
                func = F2;
            }
            else
            {
                func = F3;
            }

            double result = func(x);
            Console.WriteLine($"F({x}) = {result}");
        }

        static double F1(double x) => 2 * x + 10;

        static double F2(double x) => 5 * x * x + 10;

        static double F3(double x) => 1;
    }
}
