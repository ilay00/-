using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{


    struct Complex
    {
        public double im;
        public double re;
        // в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }



        // Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 10;
            complex1.im = 10;
            Complex complex2;
            complex2.re = 20;
            complex2.im = 20;
            Complex result = complex1.Plus(complex2);

        Console.WriteLine(result.ToString());
            Console.ReadLine();
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
            result = complex1.minus(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }


}
    


