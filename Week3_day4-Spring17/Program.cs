﻿using System;
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

            Automobile auto1 = new Automobile(4, 15, 4, 5, 2000, "Blue", 80.0d);
            auto1.Move();
            auto1.Move();
            Console.WriteLine("Automobile Distance Traveled: " + auto1.DistanceTraveled + "\n");

            Boat boat1 = new Boat(2, 500, "White", 80.0d, .90d);
            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat Distance Traveled: " + boat1.DistanceTraveled + "\n");

            Aircraft aircraft1 = new Aircraft(70, 100000, "Grey", 600);
            aircraft1.Move();
            aircraft1.Move();
            Console.WriteLine("Aircraft Distance Traveled: " + aircraft1.DistanceTraveled + "\n");
        }
    }
}
