using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GolubevDS.Sprint1.Task6.V16.Lib;
namespace Tyuiu.GolubevDS.Sprint1.Task6.V16
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Введите текс: ");
            var input = Console.ReadLine().ToLower();
               var letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        var signs = "!.-?\'"
            + "_-()".ToCharArray();

        var letterCount = letters.Count(c => input.Contains(c));
        var signCount = signs.Count(c => input.Contains(c));

        if (letterCount > signCount)
        {
            Console.WriteLine($"В тексте больше букв, чем знаков.");
        }
        else
        {
            Console.WriteLine($"В тексте столько же букв или меньше, чем знаков.");
        }

                     Console.Title = "Спринт #1 | Выполнил Голубев Д. С. | АСОиУБ 23-2";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Работа со строками класс String                                  *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнил: Голубев Дмитрий Сергеевич | АСОиУБ 23-2                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что в строке *");
            Console.WriteLine("* больше букв, чем знаков.                                               *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}
