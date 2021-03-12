using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Program
{
    class Bus : Vehicle
    {
        public Bus(
            string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmL,
            fuelTypeEnum fuelType,
            int passengerSeats,
            int sleepingSpots,
            bool toilets,
            double busHeight,
            double busWeight,
            double busLength) : base(name, km, registrationNumber, year, newPrice, towbar, kmL, fuelType)
        {
            this.PassengerSeats = passengerSeats;
            this.SleepingSpots = sleepingSpots;
            this.Toilets = toilets;
            this.BusHeight = busHeight;
            this.BusWeight = busWeight;
            this.BusLength = busLength;

            if (towbar == true)
            {
                this.DriversLisence = driversLisenceEnum.DE;
            }
            else
            {
                this.DriversLisence = driversLisenceEnum.D;
            }
        }

        public int PassengerSeats
        {
            get { return passengerSeats; }
            set { passengerSeats = value; }
        }
        public int passengerSeats;

        public int SleepingSpots
        {
            get { return sleepingSpots; }
            set { sleepingSpots = value; }
        }
        public int sleepingSpots;

        public bool Toilets
        {
            get { return toilets; }
            set { toilets = value; }
        }
        public bool toilets;

        public double BusHeight
        {
            get { return busHeight; }
            set { busHeight = value; }
        }
        public double busHeight;

        public double BusWeight
        {
            get { return busWeight; }
            set { busWeight = value; }
        }
        public double busWeight;

        public double BusLength
        {
            get { return busLength; }
            set { busLength = value; }
        }
        public double busLength;

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
            return base.ToString() + String.Format("\n {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: {7}\n {8}: {9}\n {10}: {11}",
                nameof(this.PassengerSeats),
                this.PassengerSeats,
                nameof(this.SleepingSpots),
                this.SleepingSpots,
                nameof(this.Toilets),
                this.Toilets,
                nameof(this.BusHeight),
                this.BusHeight,
                nameof(this.BusWeight),
                this.BusWeight,
                nameof(this.BusLength),
                this.BusLength
                );
        }
    }
}
