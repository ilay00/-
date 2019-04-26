using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Complex
{
    // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
    public double im;
    public double re;
    public Complex Plus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im + this.im;
        x3.re = x2.re + this.re;
        return x3;
    }

    public Complex Multis(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = (x2.im + this.im * x2.im) * (x2.re + this.re * x2.re);
        x3.re = (x2.re * x2.im - this.re * this.im)+(x2.re * this.im + x2.im * this.re)-1;
        return x3;
    }

      public Complex minus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = (x2.im + this.im * x2.im) - (x2.re + this.re * x2.re);
        x3.re = (x2.re - x2.im) + (this.re - this.im) - 1;
        return x3;

    }

    public new string ToString()
    {
        return re + "+" + im + "i";
    }
   

}
class Program
{
    static void Main(string[] args)
    {
        Complex complex1 = new Complex();
        complex1.re = 1;
        complex1.im = 1;
        Complex complex2 = new Complex();
        complex2.re = 14;
        complex2.im = 14;

        Complex result = complex1.Plus(complex2);
        Console.WriteLine(result.ToString());
        Console.ReadLine();

        Complex resultA = complex1.Multis(complex2);
        Console.WriteLine(resultA.ToString());
        Console.ReadLine();

        Complex resultB = complex1.minus(complex2);
        Console.WriteLine(resultB.ToString());
        Console.ReadLine();
    }
}
