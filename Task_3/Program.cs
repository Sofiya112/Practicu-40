using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {

        public delegate double Average(int m, int n);
        public static double AverageD(int m, int n)
        {
            // Проверка на корректность значений
            if (m > n)
            {
                Console.WriteLine("Ошибка: m должно быть меньше или равно n.");
                return 0;
            }

            int sum = 0;
            int count = 0;

            // Вычисление суммы всех чисел от m до n включительно
            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }

            // Возвращаем среднее арифметическое
            return (double)sum / count;
        }


        static void Main(string[] args)
        {
            Average del1 = new Average(AverageD);
            Average del2 = new Average(AverageD);
            Average del3 = new Average(AverageD);

            // Применение делегатов с разными диапазонами
            double result1 = del1.Invoke(1, 5);
            Console.WriteLine("Среднее арифметическое от 1 до 5: " + result1);

            double result2 = del2(10, 20);
            Console.WriteLine("Среднее арифметическое от 10 до 20: " + result2);

            double result3 = del3(30, 40);
            Console.WriteLine("Среднее арифметическое от 30 до 40: " + result3);


            Console.ReadLine();
        }
    }
}
