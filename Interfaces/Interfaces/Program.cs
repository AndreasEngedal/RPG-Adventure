using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { Model = "Cheap Model", Brand = "Cheap Brand", Mph = 80, Price = 9999, Year = 1989 };
            Car car2 = new Car { Model = "Expensive Model", Brand = "Expensive Brand", Mph = 120, Price = 149000, Year = 2014 };
            Car.cars.Add(car1);
            Car.cars.Add(car2);
            int test = Car.cars[0].CompareTo(Car.cars[1]);
            Console.WriteLine(Car.cars[test]);
            Console.ReadLine();
        }
    }
}
