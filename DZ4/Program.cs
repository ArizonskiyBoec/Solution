using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SolutionGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car();
        }

        public static void Car()
        {
            var car = new Car
            {
                Name = "lada",
                Model = "Kalina",
                Date = 2007
            };
            string json = JsonConvert.SerializeObject(car);
            var car1 = JsonConvert.DeserializeObject<Car>(json);
        }
    }
}
