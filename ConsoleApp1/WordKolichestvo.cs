using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    /// <summary>
    /// Содержит методы для подсчета слов в тексте.
    /// </summary>
    internal class WordCounter
    {
        /// <summary>
        /// Разделит текст на слова.
        /// </summary>
        /// <param name="text">Текст, который нужно разделить на слова.</param>
        /// <returns>Массив со словами.</returns>
        public string[] SplitWords(string text)
        {
            var words = new List<string>();
            var wordLength = 0;
            int i;

            for (i = 0; i < text.Length; i++)
            {
                if (wordLength != 0)
                {
                    if (Char.IsPunctuation(text[i]))
                    {
                        words.Add(text.Substring(i - wordLength, wordLength));
                        wordLength = 0;
                        i++;
                    }
                    else if (Char.IsWhiteSpace(text[i]))
                    {
                        words.Add(text.Substring(i - wordLength, wordLength));
                        wordLength = 0;
                    }
                    else
                    {
                        wordLength++;
                    }
                }
                else if (!Char.IsWhiteSpace(text[i]) && !Char.IsPunctuation(text[i]))
                {
                    wordLength++;
                }
            }

            if (!Char.IsPunctuation(text[text.Length - 1]))
            {
                words.Add(text.Substring(i - wordLength, wordLength));
            }

            return words.ToArray();
        }

        /// <summary>
        /// Считает частоту слов в массиве.
        /// </summary>
        /// <param name="allWords">Массив со словами.</param>
        /// <returns>Массив со словами и частотами.</returns>
        public object[,] CountWords(string[] allWords)
        {
            var frequency = new List<int>();
            var word = new List<string>();
            bool[] isThereWord = new bool[allWords.Length];

            for (int i = 0; i < allWords.Length; i++)
            {
                if (!isThereWord[i])
                {
                    word.Add(allWords[i]);
                    frequency.Add(1);
                    isThereWord[i] = true;

                    for (int j = 0; j < allWords.Length; j++)
                    {
                        if (!isThereWord[j] && word[i].ToLower() == allWords[j].ToLower())
                        {
                            frequency[i]++;
                            isThereWord[j] = true;
                        }
                    }
                }
            }

            var wordFrequency = new object[word.Count, 2];

            for (int i = 0; i < word.Count; i++)
            {
                wordFrequency[i, 0] = word[i];
                wordFrequency[i, 1] = frequency[i];
            }

            return wordFrequency;
        }
    }
}
