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
            Vehicle vehicle1 = new Vehicle(4, 2000, "Green", 55.0d);
            vehicle1.Move();
            vehicle1.Move();

            Console.WriteLine(vehicle1.DistanceTraveled);
        }
    }
}
