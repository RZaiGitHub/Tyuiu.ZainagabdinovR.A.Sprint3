using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint3.Task7.V10.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint3.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Зайнагабдинов Р. А. | ИСТНб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #3.7                                                            *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Зайнагабдинов Руслан Айратович | ИСТНб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* F(x)=((5x+2,5)/(sin(x)+3))+2x+cos(x)                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5]           *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль.                         *");
            Console.WriteLine("* При делении на ноль вернуть значение 0                                  *");
            Console.WriteLine("* Значения занести в массив                                               *");
            Console.WriteLine("* Значение округлитиь до двух знаков после запятой                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|     X    |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i<=len-1; i++ ) 
            {
                Console.WriteLine("|{0,5:d}  |   {1, 5:f2}    |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
