using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {




        static public void arryVal(Array array, string vals)
        {

            int targets = int.Parse(vals);


            int indexs = Array.BinarySearch(array, targets);
            int c;

            if (indexs >= 0)
            {
                c = indexs %3;



                if (c!= 0)
                {
                   
                }
                else
                {
                   
                    Console.WriteLine("Мы нашли значения.Выберите его.");
                    Console.WriteLine(c);

                }

            }

            else
            {
                indexs = -indexs;
                if (indexs >= targets) indexs = targets - 1;
                 
                // Мы не нашли цель. Выберите ближайшее значение.
                Console.WriteLine("Мы не нашли значение. Выберите ближайшее значение");
                Console.Write(indexs);

                Console.ReadLine();
            }


        }
    
    
        

        static void Main(string[] args)
        {
            int[] arrays;
            arrays = new int[5];
            Random rnd = new Random();
            for (int i= 0; i < arrays.Length; i++)
            {
                arrays[i] = rnd.Next(0,5);

               
            }
             var arval = "3";
            arryVal(arrays, arval);
             var arvals = "1";
            arryVal(arrays, arvals);




        }
    }
}
