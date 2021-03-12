using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Program
{
    class Truck : Vehicle
    {
        public Truck(
            string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmL,
            fuelTypeEnum fuelType,
            int seats,
            double loadCapacity, 
            double truckHeight, 
            double truckWeight, 
            double truckLength) : base(name, km, registrationNumber, year, newPrice, towbar, kmL, fuelType)
        {
            this.LoadCapacity = loadCapacity;
            this.TruckHeight = truckHeight;
            this.TruckWeight = truckWeight;
            this.TruckLength = truckLength;

            if (towbar == true)
            {
                this.DriversLisence = driversLisenceEnum.CE;
            }
            else
            {
                this.DriversLisence = driversLisenceEnum.C;
            }
        }

        public double LoadCapacity
        {
            get { return loadCapacity; }
            set { loadCapacity = value; }
        }
        public double loadCapacity;

        public double TruckHeight
        {
            get { return truckHeight; }
            set { truckHeight = value; }
        }
        public double truckHeight;

        public double TruckWeight
        {
            get { return truckWeight; }
            set { truckWeight = value; }
        }
        public double truckWeight;

        public double TruckLength
        {
            get { return truckLength; }
            set { truckLength = value; }
        }
        public double truckLength;

        public override double EngineSize
        {
            get { return this.engineSize; }
            set
            {
                if (value < 4.2 || value > 15.0)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be between 4.2 and 15.0 L.");

                this.engineSize = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: {7}",
                nameof(this.LoadCapacity),
                this.LoadCapacity,
                nameof(this.TruckHeight),
                this.TruckHeight,
                nameof(this.TruckWeight),
                this.TruckWeight,
                nameof(this.LoadCapacity),
                this.LoadCapacity
                );
        }
    }
}