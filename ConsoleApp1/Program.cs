using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        class StaticClass
        {
           

            public void arryVal(Array array, string vals)   //метод поиск значения дилимая на 3
            {

                int targets = int.Parse(vals);


                int indexs = Array.BinarySearch(array, targets);
                int c;

                if (indexs >= 0)
                {
                    c = indexs % 3;



                    if (c != 0)
                    {
                        Console.WriteLine("Мы нашли значения .Выберите его.");
                        Console.WriteLine(c);
                    }
                    else
                    {
                        /* Console.WriteLine("Мы нашли значения .Выберите его.");
                         Console.WriteLine(c);*/
                        Console.WriteLine("Мы нашли значения .Выберите его.");
                        Console.WriteLine(c);

                    }

                }

                else
                {
                    indexs = -indexs;
                    if (indexs >= targets) indexs = targets - 1;

                    
                    Console.WriteLine("не нашли значение Выберите ближайшее ");
                    Console.Write(indexs);

                    Console.ReadLine();
                }
            }




            public StaticClass(int arraysiz, int rendcol)    //конструктор
            {
                int[] arrayss;
                arrayss = new int[arraysiz];
                Random rnd = new Random();
                for (int i = 0; i < arrayss.Length; i++)
                {
                     arrayss[i] = rnd.Next(0, rendcol);
                    
                }

            }


           



           


        }

        static void Main(string[] args)
            {
                int[] arrays;
                arrays = new int[20];
                /*  Random rnd = new Random();
                  for (int i = 0; i < arrays.Length; i++)
                  {
                      arrays[i] = rnd.Next(0, 5);


                  }*/




                StaticClass C = new StaticClass(9, 9);
                C.arryVal(arrays, "3");
                C.arryVal(arrays, "6");
               

            }
        }
    }


 
