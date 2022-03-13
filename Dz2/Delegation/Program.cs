using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arraySort = new DelegateCl();
            arraySort.ArraySortFinish += SortFinish;
            var arrayS = new int [] {10,20,30,40,-10,-20,28,0};
            arraySort.SortArray(arrayS, ArrayS);
            Console.ReadKey();
        }

        public static int ArrayS(int i,int j)
        {
            return i+j;
        }

        static void SortFinish(object sender,EventArgs e)
        {
            Console.WriteLine(" Сортировка закончена");
        }

    }
}
