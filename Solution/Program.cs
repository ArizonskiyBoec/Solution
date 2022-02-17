using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите ваш вес: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш рост: ");
            double h = double.Parse(Console.ReadLine());
            h = h / 100;
            Program imt = new Program();
            Console.WriteLine("Индекс массы тела равен: " + imt.VIMT(m, h));
            double a=imt.VIMT(m, h);
            VivIMT(ref a);
        }
        public double VIMT(double m,double h)
        {
            return m / (h * h);
        }

        static void VivIMT(ref double a)
        {
            if (a < 16)
            {
                Console.WriteLine("У вас значительный дефицит массы тела");
                Console.ReadKey();
            }
            else if (a > 16 && a <= 18.5)
            {
                Console.WriteLine("У вас дефицит массы тела");
                Console.ReadKey();
            }
            else if (a >= 18.5 && a <= 25)
            {
                Console.WriteLine("У вас нормальная масса тела");
                Console.ReadKey();
            }
            else if (a >= 25 && a <= 30)
            {
                Console.WriteLine("У вас есть лишний вес");
                Console.ReadKey();
            }
            else if (a >= 30 && a <= 35)
            {
                Console.WriteLine("У вас ожирение первой степени");
                Console.ReadKey();
            }
            else if (a >= 35 && a <= 40)
            {
                Console.WriteLine("У вас ожирение второй степени");
                Console.ReadKey();
            }
            else if (a >= 40)
            {
                Console.WriteLine("У вас ожирение третьей степени");
                Console.ReadKey();
            }
        }
    }
}


