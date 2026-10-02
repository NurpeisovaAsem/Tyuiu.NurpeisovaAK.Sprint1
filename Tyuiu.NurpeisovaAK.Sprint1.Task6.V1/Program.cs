using Tyuiu.NurpeisovaAK.Sprint1.Task6.V1.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task6.V1
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Нурпеисова Асем Кайсаровна | ПИНб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит код введенного пользователем символа*");
            Console.WriteLine("* Программа должна завершать работу в результате ввода точки              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите символ и нажмите <Enter>.");
            Console.WriteLine();
            Console.WriteLine("Для завершения введите точку.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("-> ");

                string? value = Console.ReadLine();

                if (string.IsNullOrEmpty(value))
                    continue;
                if (value[0] == '.')
                    break;

                string code = ds.SymbolCode(value);

                Console.WriteLine();
                Console.WriteLine($"Символ: {value[0]} Код: {code}");
                Console.WriteLine();
            }
        }
    }
}

    

