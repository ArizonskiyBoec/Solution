using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Round
    {   
        //Радиус
        public double R;
        //x центр
        public double RoundDx;
        //y центр
        public double RoundDy;
        /// <summary>
        /// Задает круг с введенными данными
        /// </summary>
        /// <param name="rad">Радиус</param>
        /// <param name="x">Координата центра x</param>
        /// <param name="y">Координата центра y</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Round(double rad, double x, double y)
        {
            this.RoundDx = x;
            this.RoundDy = y;
            if (rad <= 0)
                throw new ArgumentNullException(nameof(rad), "Радиус меньше или равен нулю");
            else
                this.R = rad;
        }
        /// <summary>
        /// Нахождение длины описаной окружности
        /// </summary>
        /// <returns>Длина</returns>
        public double GetLenght()
        {
            return 2 * Math.PI * R;
        }
        /// <summary>
        /// Нахождение площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double GetS()
        {
            return Math.PI*Math.Pow(R, 2);
        }
        /// <summary>
        /// Движение круга
        /// </summary>
        /// <param name="moveX">Смещение по х</param>
        /// <param name="moveY">Смещение по у</param>
        public void Move(double moveX,double moveY)
        {
            this.RoundDx=RoundDx+moveX;
            this.RoundDy=RoundDy+moveY;
        }

    }
}
