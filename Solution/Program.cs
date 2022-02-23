using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Program
    {
        public static void Main()
        {
            ImtCalc();
        }
        

        public static void ImtCalc()
        {
            var ves = ToDouble(GetValueFromUser("Введите вес: "));
            var rost = ToDouble(GetValueFromUser("Введите рост: "));
            var imtCalc = new ImtCalc();
            var imt = imtCalc.ImtCalculate(ves, rost);
            var opis = imtCalc.GetOpis(imt);
            Console.WriteLine(imt);
            Console.WriteLine(opis);
            Console.ReadKey();
        }

        private static double ToDouble(string value)
        {
            return double.Parse(value);
        }
        private static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

    }
}


