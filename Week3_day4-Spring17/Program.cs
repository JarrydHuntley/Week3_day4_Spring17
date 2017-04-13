using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day4_Spring17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle1 = new Vehicle(4, 2000, "Green", 55.0d);
            //vehicle1.Move();
            //vehicle1.Move();

            //Console.WriteLine(vehicle1.DistanceTraveled);

            Automobile auto1 = new Automobile(4, 15, 4, 5, 2000, "Blue", 80.0d);
            auto1.Move();
            auto1.Move();
            Console.WriteLine("Automobile Distance Traveled: " + auto1.DistanceTraveled);
        }
    }
}
