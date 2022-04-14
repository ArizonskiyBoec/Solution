using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Class2
    {
        public static void GetNumbers()
        {
            var numbers = new List<int>();
            for (var i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }
            var array =numbers.ToArray();//int значения заносятся в массив
            var list = array.ToList<int>();//значения массива переходят в int
            var take = numbers.Take(5);//Выводит первые 5 элементов
            var skip=numbers.Skip(5);//выводит элементы после пятого
            var order=numbers.OrderByDescending(x => x);//Элементы по убыванию
            var any=numbers.Any();//Проверка на пустой список
            var first =numbers.First();//Первый элемент 
        }
    }
}
