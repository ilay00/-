using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
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
           var IMT = mass/ I;
            Console.WriteLine(IMT);
            Console.ReadLine();


            if (IMT <= 16)
                {
                Console.WriteLine("Недостаточная (дефицит) масса тела");
                Console.ReadLine();
                 }else if(IMT >= 18.99)
            {
                Console.WriteLine("Норма");
                Console.ReadLine();
            }
            else if (IMT >= 25)
            {
                Console.WriteLine("Избыточная масса тела (предожирение)");
                Console.ReadLine();
            }
        }
    }
}
