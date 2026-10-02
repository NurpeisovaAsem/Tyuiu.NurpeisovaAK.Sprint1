using Tyuiu.NurpeisovaAK.Sprint1.Task6.V1.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите символ и нажмите <Enter>.");
            Console.WriteLine("Для завершения введите точку.");
            Console.WriteLine();
            while (true)
            {
                



                Console.Write("-> ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    continue;

                if (input[0] == '.')
                    break;

                string code = ds.SymbolCode(input);
                Console.WriteLine($"Символ: {input[0]} Код: {code}");

            }
        }
    }
}

    

