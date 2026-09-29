using System;
using Tyuiu.NurpeisovaAK.Sprint1.Task2.V6.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 / Выполнила: Нурпеисова А. К. / ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Нурпеисова Асем Кайсаровна / ПИНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* Написать программу, которая переводит из метров в километры             *");
            Console.WriteLine("* и печатает результат на экране                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


          
            Console.WriteLine("Перевод из метров в километры = " + ds.ConvertMToKm(x).ToString("F3"));
            Console.ReadLine();



        }
    }
}
