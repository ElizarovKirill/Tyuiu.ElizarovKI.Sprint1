using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ElizarovKI.Sprint1.Task5.V3.Lib;

namespace Tyuiu.ElizarovKI.Sprint1.Task5.V3
{
    class Program
    {
        static bool isValid(int k)
        {
            return k.ToString().Length < 3;
        }

        static void Main(string[] args)
        {
            int k;
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Елизаров К. И. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Елизаров Кирилл Игоревич | ИИПб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите значение K больше 3 знаков");

            do
            {
                Console.Write("k: ");
                k = Convert.ToInt32(Console.ReadLine());

                if (isValid(k))
                    Console.WriteLine("значение должно иметь хотябы 3 знака");

            } while (isValid(k));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("h= " + ds.Calculate(k));
            Console.ReadLine();
        }
    }
}
