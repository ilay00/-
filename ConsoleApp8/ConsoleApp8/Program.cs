using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ведите логин");
            var n = Console.ReadLine();
            Console.WriteLine("ведите пароль");
            var c = Console.ReadLine();
            int count = 2;
            
            if (n == "root" && c == "Password")
            {
                Console.WriteLine("Арефметические операции над числами введите два числа");
                String a = Console.ReadLine();
                String b = Console.ReadLine();

                int num1 = Int32.Parse(a);
                int num2 = Int32.Parse(b);

                int result = num1 + num2;
                Console.WriteLine(result);
                result = num1 * num2;
                Console.WriteLine(result);

                double average = (double)(num1 + num2) / 2;
                Console.WriteLine(average);

                Console.ReadLine();
            }
            else
            {
                do
                {

                    Console.WriteLine("попытки"+ count);
                    Console.ReadLine();
                    
                }
                while(0 < count--);
                
                Console.WriteLine("попробуйте в другой раз");
                Console.ReadLine();

            }

                





        }
    }
}
