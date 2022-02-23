using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class ImtCalc
    {
        /// <summary>
        /// Вычисление и условия для входных данных
        /// </summary>
        /// <param name="ves">Вводимый вес</param>
        /// <param name="rost">Вводимый рост</param>
        /// <returns></returns>
    public double ImtCalculate(double ves,double rost)
        {
            if (ves >700 || ves <5)
            {
                Console.WriteLine("Вес должен быть не больше 700 и не меньше 5");
            }
            if (rost >300 || rost <50)
            {
                Console.WriteLine("Рост должен быть не больше 300 см и не меньше 50 см");
            }
            double imt;
            imt=ves/((rost/100)*(rost/100));
            return imt;
        }
        /// <summary>
        /// Возвращает описание к конечному результату
        /// </summary>
        /// <param name="imt">Имт полученный выше</param>
        /// <returns></returns>
        public string GetOpis(double imt)
        {
            string opisanie;
            if (imt < 16)
            {
                opisanie = "У вас значительный дефицит массы тела";
            }
            else if (imt > 16 && imt <= 18.5)
            {
                opisanie = "У вас дефицит массы тела";
            }
            else if (imt >= 18.5 && imt <= 25)
            {
                opisanie = "У вас нормальная масса тела";
            }
            else if (imt >= 25 && imt <= 30)
            {
                opisanie = "У вас есть лишний вес";
            }
            else if (imt >= 30 && imt <= 35)
            {
                opisanie = "У вас ожирение первой степени";
            }
            else if (imt >= 35 && imt <= 40)
            {
                opisanie = "У вас ожирение второй степени";
            }
            else
            {
                opisanie = "У вас ожирение третьей степени";
            }
            return opisanie;
        }
    }
    
}
