using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp15
{

       



    class Program
    {




        static void Main(string[] args)
        {


           

            StreamReader sr = new StreamReader("data.txt", Encoding.Default);   // чтения из файла
            Console.WriteLine( "Количество учиников:" + sr.ReadLine()+ "\nУченики с наименшеми баломи");

            int counter = 0;
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                counter++;

            }
            Console.WriteLine();

         


            if (counter > 10 && counter < 100)         //проверка на количество строк в файле
            {




            }
            else { Console.WriteLine("Не допустимое количество"); }




            sr.Close();

            string GetString(string fileName, string keyWord)    //поиск по файлу
            {
                StreamReader reader = new StreamReader(fileName, Encoding.Default);
                {
                    string lines;
                    while ((lines = reader.ReadLine()) != null)
                    {
                        if (lines.Contains(keyWord))
                            Console.WriteLine(lines); 
                    }
                }
                return null; //если слово не нашли вернем null
            };


            string str = GetString("data.txt" ,"3");    //вызов метода поиска по файлу

           

               Console.WriteLine(str); //вывод в кансоль трех учеников
            Console.ReadLine();



        }

    }
}
