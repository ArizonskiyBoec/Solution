using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    internal class DelegateCl
    {

        public delegate int DelegateArray<T>(T i, T j);

        public EventHandler ArraySortFinish;

        public void SortArray<T>(T[] a, DelegateArray<T> mass)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (mass(a[i], a[j]) < 0)
                    {
                        var array = a[i];
                        a[i] = a[j];
                        a[j] = array;
                    }
                }
            }
            foreach (var i in a)
            {
                Console.Write(" " + i);
            }
            if (ArraySortFinish != null)
            {
                ArraySortFinish.Invoke(this, null);
            }
        }
    }
}
