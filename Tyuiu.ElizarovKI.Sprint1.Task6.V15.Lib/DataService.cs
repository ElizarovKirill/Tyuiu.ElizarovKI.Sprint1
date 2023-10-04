using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ElizarovKI.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        private static bool IsCyrillic(char c)
        {
            return c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я';
        }

        private static bool IsLatin(char c)
        {
            return c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z';
        }

        public bool CheckLettersCount(string value)
        {
            int a = 0;
            int b = 0;

            for (int i = 0; i < value.Length - 1; ++i)
            {
                if (IsCyrillic(value[i]) || IsLatin(value[i]))
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            return a > b;
        }

    }
}
