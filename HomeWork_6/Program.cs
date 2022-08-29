using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using HomeWork;

namespace HomeWork_6
{
    // 1.Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
    // типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и
    // функцией a*sin(x).


    // 2. Модифицировать программу нахождения минимума функции так, чтобы можно было
    // передавать функцию в виде делегата.
    // а) Сделать меню с различными функциями и представить пользователю выбор, для какой
    // функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов,
    // в котором хранятся различные функции.

    // решение предоставил Юрченко Н.А.

    public delegate double Fun(double x);

    class Program
    {

        static void Main(string[] args)
        {
            var screen = new Screen();
            screen.ScreenPrint(6,1);
            // Вызов метода ScreenPrint cо второй домашней работы, для вывода номера задания 
            // и домашней работы, а также вывода ФИО выполнившего студента

            List<Fun> functions = new List<Fun> { new Fun(Func2.Quardratic), new Fun(Func2.Linear), new Fun(Func2.Squaring), new Fun(Func2.Cubing), new Fun(Func2.Sqrt), new Fun(Func2.Sin) };
            Console.WriteLine("Выберите номер функции");
            Console.WriteLine("1. f(x) = a * x^2 (3 * x^2)");
            Console.WriteLine("2. f(x) = k * x + b (2 * x + 3)");
            Console.WriteLine("3. f(x) = x^2");
            Console.WriteLine("4. f(x) = x^3");
            Console.WriteLine("5. f(x) = x^1/2");
            Console.WriteLine("6. f(x) = Sin(x)\n");

            Console.Write("Номер функции:  ");
            int Choose = Get.GetInt(functions.Count);

            Console.WriteLine();
            Console.Write("Для нахождения минимума введите отрезок в формате х0 хn:  ");

            double start = 0;
            double end = 0;
            Get.GetInterval(out start, out end);

            Console.WriteLine();
            Console.Write("Введите размер шага:  ");
            double step = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Get.SaveFunc("data.bin", start, end, step, functions[Choose - 1]);
            double min = double.MaxValue;

            Console.WriteLine();
            Console.WriteLine("Получены следующие значения функции:\n");
            Table2.Table(start, end, step, Get.Load("data.bin", out min));

            Console.WriteLine();
            Console.WriteLine("Минимальное значение функции: {0:0.00}", min);
            Console.ReadKey();
        }
    }
}