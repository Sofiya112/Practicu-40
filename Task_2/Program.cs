using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {

            Operation del = new Operation(Add);
            int result = del.Invoke(4, 5); 
            Console.WriteLine("Сумма: " + result);

            del = Subtraction;
            result = del.Invoke(4, 5); 
            Console.WriteLine("Разность: " + result);

            del = Multiply;
            result = del.Invoke(4, 5); 
            Console.WriteLine("Произведение: " + result);

            
            del = Division;
            result = del.Invoke(4, 2); 
            Console.WriteLine("Деление: " + result);

            Console.Read();

        }
        private static int Add(int x, int y)  // Сумма
        {
            return x + y;
        }

        private static int Subtraction(int x, int y)  // Разность
        {
            return x - y;
        }

        private static int Multiply(int x, int y)  // Произведение
        {
            return x * y;
        }

        private static int Division(int x, int y)  // Деление
        {
            if (y == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
                return 0;
            }
            return x / y;
        }
    }
}
