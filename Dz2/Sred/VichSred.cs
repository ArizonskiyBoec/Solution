using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sred
{
    internal class VichSred
    {
        /// <summary>
        /// Массив символов и пробелов
        /// </summary>
        /// <param name="str">строка</param>
        /// <returns>Массив с символами и пробелами</returns>
        public char[] Punct(string str)
        {
            int arrayRazm=str.Length;
            char[] vs=new char[arrayRazm];
            for (int i=0; i<arrayRazm; i++)
            {
                if (char.IsWhiteSpace(str[i])||char.IsPunctuation(str[i]))
                { 
                    vs[i]=str[i];
                }
            }
            return vs;
        }
        /// <summary>
        /// Разделение строки на подстроки
        /// </summary>
        /// <param name="str">введенная строка </param>
        /// <param name="vs">массив с разделительными знаками</param>
        /// <returns>массив слов</returns>
        public string[] StringRazdel(string str,char[] vs)
        {
            string[] slovo = str.Split(vs);
            return slovo;
        }
       /// <summary>
       /// Создание массива с каждой длинной слова 
       /// </summary>
       /// <param name="slovo">массив слов</param>
       /// <returns>возвращение массива слов</returns>
        public int[] StrokaDlina(string[] slovo)
        {
            int dlSl;
            int[] dl=new int[slovo.Length];
            for (int i=0;i<slovo.Length;i++)
            {
                if (slovo[i].Length != 0)
                {
                    dlSl=slovo[i].Length;
                    dl[i] = dlSl;
                    Console.WriteLine(dl[i]);
                }
            }
            return dl;
        }
        /// <summary>
        /// Вычисляет среднее число массива
        /// </summary>
        /// <param name="dl">Массив длин слов</param>
        /// <returns>Возвращает среднее значение</returns>
        public double Sredn(int[] dl)
        {
            double sr=dl.Average();
            Console.WriteLine("Среднее кол-во букв = "+sr);
            return sr;
        }
    }
}
