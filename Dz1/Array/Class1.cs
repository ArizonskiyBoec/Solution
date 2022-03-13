using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    /// <summary>
    /// Создает несортированный массив
    /// Заполняет его и выводит значение
    /// Сортирует его и выводит значение
    /// Ищет минимальное число в массиве
    /// Ищет максимальное число в массиве
    /// </summary>
    internal class Massiv
    {
        /// <summary>
        /// Создание и заполнение несортированного массива
        /// </summary>
        /// <returns>Несортированный массив</returns>
        public int[] ArrayUnSort()
        {
            int[] mass = new int[7];
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = random.Next(0, 100);

        }
            Console.WriteLine("Unsorted");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            return mass;
        }
        /// <summary>
        /// Сортирует массив и выводит его
        /// </summary>
        /// <param name="mass">Несортированный массив</param>
        /// <returns>Сортированный массив</returns>
        public int[] ArraySort(int[] mass)
        {
            int a;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        a = mass[i];
                        mass[i] = mass[j];
                        mass[j] = a;
                    }
                }
            }
            Console.WriteLine( );
            Console.WriteLine("Sorted ");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            return mass;    
        }
        /// <summary>
        /// Ищет минимальное значение массива
        /// </summary>
        /// <param name="mass">Принимает несортированный массив</param>
        /// <returns>Возвращает минимальное число</returns>
        public int ArrayMin(int[] mass)
        {
            int min = 1000;
            for (int i = 0;i<mass.Length;i++)
            {
                if (mass [i] <min)
                {
                    min = mass[i];
                }
            }
            return min;
        }
        /// <summary>
        /// Ищет максимальное значение массива
        /// </summary>
        /// <param name="mass">Принимает несортированный массив</param>
        /// <returns>Возвращает максимальное число</returns>
        public int ArrayMax(int[] mass)
        {
            int max = -1;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i]> max)
                {
                    max = mass[i];
                }
            }
            return max;
        }
    }
}
    

