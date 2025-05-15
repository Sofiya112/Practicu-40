using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_pr4
{
  
    
    class Program
    {
        //вычисления суммы чисел от m до n
        static int SumRange(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
                sum += i;
            return sum; 
        }

        delegate int SumDelegate(int m, int n);

        static void Task4()
        {
            SumDelegate sumDel = SumRange;

            Console.WriteLine($"Сумма (1, 5): {sumDel(1, 5)}");
            Console.WriteLine($"Сумма (10, 15): {sumDel(10, 15)}");
            Console.WriteLine($"Сумма (100, 105): {sumDel(100, 105)}");
        }

        static void Main(string[] args)
        {
            Task4(); 

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadLine();  
        }
    }
}


