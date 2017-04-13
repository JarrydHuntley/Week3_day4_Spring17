using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day4_Spring17
{
    class Boat : Vehicle
    {
        private double waterDrag;

        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }

        //the version from the parent class doesn't work for us so we overrode it and removed the base.Move()
        public override void Move()
        {
            distanceTraveled += movementSpeed * waterDrag;
        }
    }
}
