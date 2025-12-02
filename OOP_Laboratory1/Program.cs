using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR_One
{
    class Programm
    {
        static void Main(string[] args)
        {
            int a_1 = 4, b = 5, x = -2, y = 3;
            string str = "Hello World!";


            string LR_ORDER = "Лабораторная работа 1";
            string LR_NAME = "РАЗРАБОТКА КОНСОЛЬНОГО ПРИЛОЖЕНИЯ";

            Console.WriteLine("- {0}. {1}", LR_ORDER, LR_NAME);
            Console.WriteLine("- Содномов Тумэн Викторович");
            Console.WriteLine("- ИДБ-23-01");
            Console.WriteLine("- 27.08.05");
            Console.WriteLine("- Moscow");
            Console.WriteLine("- Физра");
            Console.WriteLine("Увольняйте, я ленивый пес и т.д.");
            Console.WriteLine("================================");
            Console.WriteLine("a_1 = {0}, b = {1}, x = {2}, y = {3}", a_1, b, x, y);
            Console.WriteLine("Fy = {0}", a_1 + b - a_1 * (x + y));
            Console.ReadKey();

            
        }
    }
}