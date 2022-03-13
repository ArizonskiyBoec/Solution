using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    internal class DynamicArray<T>
    {
        public T[] array { get; set; }

        public int length => array.Length;

        public int Capacity => array.Count();
        /// <summary>
        /// 1
        /// </summary>
        public DynamicArray()
        {
            array = new T[8];
        }

        /// <summary>
        /// 2
        /// </summary>
        /// <param name="lenght">Указанная емкость</param>
        public DynamicArray(int lenght)
        {
            array = new T[lenght];
        }
        /// <summary>
        /// 3
        /// </summary>
        /// <param name="myArray"></param>
        public DynamicArray(IEnumerable<T> myArray)
        {
            array=new T[array.Count()];
            myArray.ToList().CopyTo(array, 0);
            return;
        }
        /// <summary>
        /// 4
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public T[] Add(T item)
        {
            if (Capacity+1==length)
            {
                array = new T[array.Length * 2];
                return array;
            }
            else
            {
                array.Append(item);
                return array;
            }
        }
    }
}
