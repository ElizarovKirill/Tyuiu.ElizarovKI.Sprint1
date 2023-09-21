using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ElizarovKI.Sprint1.Task3.V19.Lib;

namespace Tyuiu.ElizarovKI.Sprint1.Task3.V19
{
    class Program
    {
        static int readInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            DataService ds = new DataService();

             Console.Title = "Спринт #1 | Выполнил: Елизаров К. И. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Елизаров Кирилл Игоревич | ИИПб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите x1 = ");
            int x1 = readInt();

            Console.WriteLine("Введите x2 = ");
            int x2 = readInt();

            Console.WriteLine("Введите y1 = ");
            int y1 = readInt();

            Console.WriteLine("Введите y2 = ");
            int y2 = readInt();

            bool result = ds.ElephCanMove(x1, x2, y1, y2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (result)
            {
                Console.WriteLine("Слон может сходить");
            }
            else
            {
                Console.WriteLine("Слон не может сходить");
            }

            Console.ReadLine();
        }
    }
}
