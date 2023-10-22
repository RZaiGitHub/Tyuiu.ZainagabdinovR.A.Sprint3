using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint3.Task1.V7.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint3.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Зайнагабдинов Р. А. | ИСТНб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #3.1                                                            *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Зайнагабдинов Руслан Айратович | ИСТНб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while,                                *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле, при a=0,25                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 9;

            Console.WriteLine("Переменная X = " + value);

            Console.WriteLine("Старт шага = " + startValue);

            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение рада = " + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadLine();
        }
    }
}
