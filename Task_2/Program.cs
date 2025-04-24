using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация делегатов
            MathOperation sum = new MathOperation(Sum);
            MathOperation subtraction = new MathOperation(Subtraction);
            MathOperation multiplication = new MathOperation(Multiplication);
            MathOperation division = new MathOperation(Division);

            // Пример использования делегатов
            double a = 10;
            double b = 5;

            Console.WriteLine($"Сумма: {sum(a, b)}");
            Console.WriteLine($"Разность: {subtraction(a, b)}");
            Console.WriteLine($"Произведение: {multiplication(a, b)}");
            Console.WriteLine($"Деление: {division(a, b)}");

            // Можно легко изменить методы через делегат
            // Например, для деления:
            MathOperation currentOperation = division;
            Console.WriteLine($"Результат деления: {currentOperation(a, b)}");

            Console.ReadLine();

        }
        public static double Sum(double a, double b) //сумма
        {
            return a + b;
        }

        public static double Subtraction(double a, double b) //Разность
        {
            return a - b;
        }

        public static double Multiplication(double a, double b) //Произведение
        {
            return a * b;   
        }

        public static double Division(double a, double b) //Деление
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
                return 0;
            }
            return a / b;
        }
        public delegate double MathOperation(double a, double b);

    }
}
