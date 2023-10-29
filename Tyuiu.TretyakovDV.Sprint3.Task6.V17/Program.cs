using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TretyakovDV.Sprint3.Task6.V17.Lib;

namespace Tyuiu.TretyakovDV.Sprint3.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Третьяков Д.В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Третьяков Денис Викторович | ПКТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку[10, 20] количество всех делителей                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите startValue");
            int startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите stopValue");
            int stopValue = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            int count = ds.GetSumTheDivisors(startValue, stopValue);
            Console.WriteLine(count);
            Console.ReadKey();


        }
    }
}