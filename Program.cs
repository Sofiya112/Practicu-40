using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicu_40
{
    class Program
    {
        delegate void Message(); //Объявление делегата 
            /*static  void Hello() //Объявили метод для вывода
            {
                            Console.WriteLine("Привет делегат");
            }*/
        static void Main(string[] args)
        {
            /* Message message = Hello; //Создаём переменную делегата и пресваиваем этой перпеменной метод
             message();*/

            Message message;
            try
            {
                Console.WriteLine("Введите время");
                string input = Console.ReadLine();

                DateTime now = DateTime.Now;
                DateTime userTime = DateTime.Parse($"{now.ToShortDateString()} {input}");

                if (now < userTime)
                {
                    message = GoodMorning;
                }
                else
                {
                    message = GoodEvening;
                }
                message();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат времени.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }




            Console.ReadLine();
        }
        static void GoodMorning()
        {
            Console.WriteLine("Доброе утро!");
        }
        static void GoodEvening()
        {
            Console.WriteLine("Добрый вечер! ");
        }

    }
}
