using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sred
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DlinaStroki();
        }
        public static void DlinaStroki()
        {
            string str = GetValueFromUser("Введите строку");
            var avg = new VichSred();
            char[] vs = avg.Punct(str);
            string [] slovo=avg.StringRazdel(str, vs);
            int[] dl=avg.StrokaDlina(slovo);
            var sr = avg.Sredn(dl);
            Console.ReadLine();
        }

        private static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
