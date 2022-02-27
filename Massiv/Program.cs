using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mass();
        }
        public static void Mass()
        {
            var massSet = new Massiv();
            int[] mass=massSet.ArrayUnSort();
            int[] massort = massSet.ArraySort(mass);
            var max = massSet.ArrayMax(mass);
            var min = massSet.ArrayMin(mass);
            Console.WriteLine( );
            Console.WriteLine("Max " + max);
            Console.WriteLine("Min " + min);
            Console.ReadKey();
        }
    }
}
