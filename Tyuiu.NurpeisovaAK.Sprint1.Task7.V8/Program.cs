using System.Runtime.CompilerServices;
using Tyuiu.NurpeisovaAK.Sprint1.Task7.V8.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Нурпеисова А. К. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Нурпеисова Асем Кайсаровна | ПИНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая переводит значения из Фаренгейта в градусы  *");
            Console.WriteLine("* Цельсия и печатает результат на экран                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                  y");
            Console.WriteLine("z = ln(x) + -------------");
            Console.WriteLine("             cos(x)-x/3");
            double x, y;
            Console.WriteLine("Введите значение х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РУЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(Math.Round(ds.Calculate(x, y), 3));
            Console.ReadKey();




        }
    }
}
