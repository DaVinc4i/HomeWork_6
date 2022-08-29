using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    class Table2
    {
        public static void Table(double start, double end, double step, double[] values) // метод выводит на экран значения функции и аргумента
        {
            Console.WriteLine("------- X ------- Y -----");
            int index = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start, values[index]);
                start += step;
                index++;
            }
            Console.WriteLine("--------------------------");
        }

    }
}