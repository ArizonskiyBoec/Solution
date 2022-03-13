using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordsAvg();
        }
        private static void WordsAvg()
        {
            var stringUser = GetStringUser("Введите строку");
            var slovoKolvo = new Word();
            var getWords = slovoKolvo.GetWordsArray(stringUser);
            var slovoAvg = slovoKolvo.NumWord(getWords);
            Console.ReadKey();
        }
        public static string GetStringUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().ToLower();
        }
    }
}
