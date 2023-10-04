using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ElizarovKI.Sprint1.Task6.V15.Lib;


namespace Tyuiu.ElizarovKI.Sprint1.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Елизаров К. И. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Елизаров Кирилл Игоревич | ИИПб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что в строке больше букв, чем знаков.                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckLettersCount(str))
            {
                Console.WriteLine("Букв большн чем символов");
            }
            else
            {
                Console.WriteLine("Cимволов больше чем букв");
            }

            Console.ReadLine();
        }
    }
}
