﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_day4_Spring17
{
    class Vehicle
    {
        //fields
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;

        private float gearRatio;
        private float engineSize;
        private double distanceTraveled;

        //properties
        public int Seats
        {
            get { return this.seats; }
        }

        public int CarryingCapacity
        {
            get { return this.carryingCapacity; }
        }

        public string Color
        {
            get { return this.color; }
        }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }

        //constructors
        public Vehicle()
        {
 
        }

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            distanceTraveled = 0.0d;
        }

        public virtual void Move()
        {
            //shorthand for the following distanceTraveled = distanceTraveled + movementSpeed;
            distanceTraveled += movementSpeed;
        }

    }
}
