using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double y1;
            double x2;
            double y2;
               Console.WriteLine("кординат 1 \n");
               string kor1= Console.ReadLine();
               x1 = Convert.ToDouble(kor1);
            Console.WriteLine("кординат 2 \n");
            string kor2 = Console.ReadLine();
            y1 = Convert.ToDouble(kor2);
            Console.WriteLine("кординат 3 \n");
            string kor3 = Console.ReadLine();
            x2 = Convert.ToDouble(kor3);
            Console.WriteLine("кординат 4 \n");
            string kor4 = Console.ReadLine();
            y2 = Convert.ToDouble(kor4);
           var r = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            Console.WriteLine("расстояние между точками =" + r);
            Console.ReadLine();

        }
    }
}
