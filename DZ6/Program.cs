using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SetRound();
        }
        public static void SetRound()
        {
            var x = ToDouble(GetValueFromUser("Введите x координату центра"));
            var y = ToDouble(GetValueFromUser("Введите y координату центра"));
            var rad = ToDouble(GetValueFromUser("Введите радиус"));
            var round =new Round(rad, x, y);
            RoundMove(round);
        }

        private static double ToDouble(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new ArgumentException();
            return double.Parse(value);
        }

        public static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        /// <summary>
        /// Задает координаты смещения в класс
        /// </summary>
        /// <param name="round">готовый круг</param>
        public static void RoundMove(Round round)
        {
            var moveX = ToDouble(GetValueFromUser("Введите x смещение"));
            var moveY = ToDouble(GetValueFromUser("Введите y смещение"));
            round.Move(moveX, moveY);
        }
    }
}
