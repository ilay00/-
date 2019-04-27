using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
       
            static bool Odd(int a)
            {
                return a % 2 == 0;
            }
            static void Main(string[] args)
            {
                int x;
                Console.WriteLine("Введите целое число.");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x + " - " + ((Odd(x)) ? "четное число" : "нечетное число" ));
                Console.WriteLine("Для выхода из приложение нажмите Enter");
                Console.ReadLine();
            }
        









       
    }
}
