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
            void Sortirovka()
            {
                int[] mass = new int[7];
                int max=0;
                int min=100; 
                Random random = new Random();
                Console.WriteLine("Начальный массив: ");
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i]=random.Next(1,100);
                    if (mass[i] > max)
                    {
                        max=mass[i];
                    }
                    if (mass[i] < min)
                    {
                        min = mass[i];
                    }
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write(mass[i] + " ");
                }
                Console.WriteLine("\nОтсортированный массив");
                int a;
                for (int i = 0;i<mass.Length-1;i++)
                {
                    for (int j = i+1;j<mass.Length;j++)
                    {
                        if (mass[i]>mass[j])
                        {
                            a=mass[i];
                            mass[i]=mass[j];
                            mass[j]=a;
                        }
                    }
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write(mass[i] + " ");
                }
                Console.WriteLine("\nMax "+max+"\nMin "+min);

                Console.ReadKey();
            }
            Sortirovka();

         
        }
    }
}
