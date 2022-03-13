using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    internal class Word
    {
        public string[] GetWordsArray(string stringUser)
        {
            string[] getWords = stringUser.Split(' ', ',', '.', ':', ';', '!', '?');
            return getWords;
        }

        public object[,] NumWord(string[] getWord)
        {
            var kolvo = new List<int>();
            var stroka = new List<string>();
            for (var i = 0; i < getWord.Length; i++)
            {
                stroka.Add(getWord[i]);
                kolvo.Add(0);
                for (var j = 0; j < getWord.Length; j++)
                {
                    if (stroka[i].ToLower() == getWord[j].ToLower())
                    {
                        kolvo[i]++;
                    }

                }
            }
            var slovoKolvo = new object[getWord.Length, 2];
            for (var i = 0; i < getWord.Length; i++)
            {
                slovoKolvo[i, 0] = stroka[i];
                slovoKolvo[i, 1] = kolvo[i];
                Console.WriteLine($"{ (slovoKolvo[i, 0])}:{ (slovoKolvo[i, 1])}");
            }
            return slovoKolvo;
        }
    }
}
