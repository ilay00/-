using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IMT
    {
        static void Main(string[] args)
        {
            double rost;
            double mass;
            

            //расчет массы и роста

            Console.WriteLine("Ваш вес \n");
            string mas = Console.ReadLine();
            mass = Convert.ToDouble(mas);
            Console.WriteLine("При вводе поставить запетую Ваш рост \n");
            string ros = Console.ReadLine();
            rost = Convert.ToDouble(ros);



           

            //I= m/(h * h);

            var I = rost * rost;
            var IMT = I / mass;

            Console.WriteLine("Вывести индекс массы тела" + IMT);
            Console.ReadLine();
        }
    }
}
