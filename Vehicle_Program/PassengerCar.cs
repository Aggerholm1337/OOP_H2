using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Vehicle_Program
{
    abstract class PassengerCar : Vehicle
    {
        public PassengerCar(string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double engineSize,
            double kmL,
            fuelTypeEnum fuelType,
            int seats,
            storageDimensionsStructure storageDimensions) : base(name, km, registrationNumber, year, newPrice, towbar, kmL, fuelType)
        {
            this.Seats = seats;
            this.StorageDimensions = storageDimensions;
            this.EngineSize = engineSize;
        }

        public int Seats
        {
            get { return seats; }
            set { 
                var r = new Regex(@"^[2-7]{1}$");

                if (!r.IsMatch(value.ToString()))
                    throw new Exception("Antal sæder er ikke gyldigt!");

                else
                    seats = value;
            }
        }
        private int seats;

        public storageDimensionsStructure StorageDimensions
        {
            get { return storageDimensions; }
            set { storageDimensions = value; }
        }
        private storageDimensionsStructure storageDimensions;
        public struct storageDimensionsStructure
        {
            public double height;
            public double width;
            public double depth;
            public override string ToString() => $"({height}, {width}, {depth})";
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}\n {2}: {3}",
                nameof(this.Seats),
                this.Seats,
                nameof(this.StorageDimensions),
                this.StorageDimensions.ToString()
                );
        }
    }

    class PrivatePassengerCar : PassengerCar
    {
        public PrivatePassengerCar(
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
            storageDimensionsStructure storageDimensions,
            bool isofix) : base(name, km, registrationNumber, year, newPrice, towbar, engineSize, kmL, fuelType, seats, storageDimensions)
        {
            this.Isofix = isofix;
            this.DriversLisence = driversLisenceEnum.B;
        }

        public bool Isofix
        {
            get { return isofix; }
            set { isofix = value; }
        }
        private bool isofix;

        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}",
                nameof(this.Isofix),
                this.Isofix
                );
        }
    }

    class CommercialPassengerCar : PassengerCar
    {
        public CommercialPassengerCar(
            string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            double engineSize,
            double kmL,
            fuelTypeEnum fuelType,
            int seats,
            storageDimensionsStructure storageDimensions,
            bool safetyBar,
            double loadCapacity) : base(name, km, registrationNumber, year, newPrice, true, engineSize, kmL, fuelType, seats, storageDimensions)
        {
            this.SafetyBar = safetyBar;
            this.Seats = 2;
            this.LoadCapacity = loadCapacity;
            this.Towbar = true;

            if (this.loadCapacity > 750.0)
            {
                this.DriversLisence = driversLisenceEnum.BE;
            }
            else
            {
                this.DriversLisence = driversLisenceEnum.B;
            }
        }

        public bool SafetyBar
        {
            get { return safetyBar; }
            set { safetyBar = value; }
        }
        public bool safetyBar;

        public double LoadCapacity
        {
            get { return loadCapacity; }
            set { loadCapacity = value; }
        }
        public double loadCapacity;

        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}\n {2}: {3}",
                nameof(this.SafetyBar),
                this.SafetyBar,
                nameof(this.LoadCapacity),
                this.LoadCapacity
                );
        }
    }
}
