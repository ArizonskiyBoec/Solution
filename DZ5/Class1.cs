using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    public class Collection
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static void GetColl()
        {
            var coll = new List<int>();
            for (var i = 0; i < 20;i++)
            {
                coll.Add(i);
            }
            //Доступ к коллекции через Фильтрацию
            var sort = from item in coll
                       where item < 10
                       select item;
            foreach(var item in sort)
            {
                Console.WriteLine(item);
            }
            //Коллекция через группировку
            var coll1 = new Collection[]
            {
                new Collection {Name = "Tesla",Age=2020 },
                new Collection {Name ="Tesla",Age=2021}
            };
            var group = coll1.GroupBy(a => a.Age > 2020);
            Console.ReadLine();
        }
    }
}
