using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Properties()
        {
            Console.WriteLine($"My car is a {Make}, of the model {Model} and its from the year {Year}");
        }
    }
}
