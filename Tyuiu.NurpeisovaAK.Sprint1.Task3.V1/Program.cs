using Tyuiu.NurpeisovaAK.Sprint1.Task3.V1.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task3.V1
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Нурпеисова Асем Кайсаровна / ПИНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* и вычисляет объём цилиндра                                              *");
            Console.WriteLine("* и печатает результат на экране                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double r = 10;
            double h = 20;
            Console.WriteLine("Радиус цилиндра = " + r);
            Console.WriteLine("Высота цилиндра = " + h);
            Console.WriteLine("Объём цилиндра = " + ds.CylinderVolume(r,h).ToString("F3"));
            Console.ReadKey();
        }
    }
}
