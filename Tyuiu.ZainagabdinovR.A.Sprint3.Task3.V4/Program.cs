using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint3.Task3.V4.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint3.Task3.V4
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
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3.3                                                            *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Зайнагабдинов Руслан Айратович | ИСТНб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить из строки                                *");
            Console.WriteLine("* все буквы j в строке: plkjjdw cvjkl                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "plkjjdw cvjkl";
            char item = 'j';

            Console.WriteLine("Исходная строка = " + value);

            Console.WriteLine("Искомый символ = " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" = " + ds.DeleteCharInString(value, item));

            Console.ReadLine();
        }
    }
}
