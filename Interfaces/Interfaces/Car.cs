using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface Cars
    {
        string Model { get; set; }
        string Brand { get; set; }
        int Year { get; set; }
        double Mph { get; set; }
        decimal Price { get; set; }

    }
    class Car : Cars, IComparable
    {
        public static List<Car> cars = new List<Car>();
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public double Mph { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is Car))
                throw new ArgumentException("Object is not a Car");

            Car other = obj as Car;
            return Model.CompareTo(other.Model);
        }
    }
}
