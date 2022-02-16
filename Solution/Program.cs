using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш вес: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш рост: ");
            double h = double.Parse(Console.ReadLine());
            h = h / 100;
            Program imt = new Program();
            Console.WriteLine("Индекс массы тела равен: " + imt.VIMT(m, h));
            Console.ReadKey();

        }
        public double VIMT(double m,double h)
        {
            return m / (h * h);
        }
    }
}


