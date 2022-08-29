using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace HomeWork_6
{
    class Get
    {
        public static void SaveFunc(string fileName, double start, double end, double step, Fun F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            while (start <= end)
            {
                bw.Write(F(start));
                start += step;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] array = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return array;
        }

        public static void GetInterval(out double start, out double end)
        {
            string[] interval = Console.ReadLine().Split(' ');
            start = double.Parse(interval[0], CultureInfo.InvariantCulture);
            end = double.Parse(interval[1], CultureInfo.InvariantCulture);
        }

        public static int GetInt(int max)
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
                    Console.Write("Неверный ввод. Необходимо ввести число от 0 до {0}.\nПовторите ввод: ", max);
                else return x;
        }

    }
}