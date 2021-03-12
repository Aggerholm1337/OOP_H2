using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Vehicle_Program
{
    abstract class Vehicle
    {
        protected Vehicle(string name,
            double km,
            string registrationNumber,
            int year,
            double newPrice,
            bool towbar,
            double kmL,
            fuelTypeEnum fuelType)
        {
            this.Name = name;
            this.Km = km;
            this.RegistrationNumber = registrationNumber;
            this.Year = year;
            this.NewPrice = newPrice;
            this.KmL = kmL;
            this.FuelType = fuelType;
            this.engeryClass = GetEnergyClass();
        }

        public string licenseTypeMessage = "Kræver kørekort: ";

        // Name returnere en fejlbesked via NullException hvis input er null.
        public string Name
        {
            get { return name; }
            set { if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }
                name = value; 
            }
        }
        private string name;

        // Antal km som køretøjet har kørt, returnere fejlbesked hvis input er under 0 eller over 1 mill.
        // Vil jeg gerne skrive om til at matche regex. 
        public double Km
        {
            get { return km; }
            set { if (km < 0)
                    throw new Exception("Indastede KM værdi er negativ og derfor ikke gyldig.");

                else if (km > 1000000)
                    throw new Exception("Indastede KM værdi er for høj og derfor ikke gyldig.");

                else
                    km = value;
            }
        }
        private double km;

        // Regex som validere om input matcher værdien "2 bogstaver efterfulgt af 5 bogstaver".
        // Så returnere vi regnr med "ToUpper", da alle bogstaver i regnr skal være store.
        // Hvis ikke input værdien matcher med vores regular expression, returnere vi en fejlbesked.
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { 
                var r = new Regex(@"^[a-zA-Z]{2}\d{5}$");
                if (!r.IsMatch(value))
                    throw new Exception("Registreringsnummeret er ikke gyldigt!");

                else
                    registrationNumber = value;
            }
        }
        private string registrationNumber;



        // Year matcher med vores regex for at validere om input er 4 tal uden mellemrum.
        // Hvis ikke, returnere vi fejlbesked.

        public int Year
        {
            get { return year; }
            set {
                var r = new Regex(@"^\d{4}$");
                if (!r.IsMatch(value.ToString()))
                    throw new Exception("Årgang er ikke gyldigt!");

                else
                    year = value; }
        }
        private int year;

        // Nypris matcher vi med regex som validere at input er tal, og skal have enten 5 eller 6 eller 7 digits,
        // for at prisen kan have en værdi mellem 10.000 - 9.999.999 Kr.

        public double NewPrice
        {
            get { return newPrice; }
            set {
                var r = new Regex(@"^\d{5,7}$");

                // Hvis prisen bliver angivet i minues, sætter vi prisen til 0. <- lidt mærkeligt, men det siger opgaven.
                // jeg vil mene at de burde returnere fejl, da en bil ikke normal skal kunne være gratis?
                if (value < 0)
                { 
                    value = 0;
                    newPrice = value;
                }
                // Hvis vores input ikke matcher vores regex digit range, returnere vi fejlbesked. 
                else if (!r.IsMatch(value.ToString()))
                    throw new Exception("Nypris er ikke gyldig!");

                else
                    newPrice = value; }
        }
        private double newPrice;

        // Towbar har en override metode i passengerCars klassen, som overskriver ved alle passengerCars
        // Hvis ikke Towbar bliver overskrevet fra passengerCars, bliver værdien sat ud fra user input bool værdi.

        public bool Towbar
        {
            get { return towbar; }
            set { towbar = value; }
        }
        private bool towbar;

        public virtual double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }
        protected double engineSize;

        public double KmL
        {
            get { return kmL; }
            set { if (kmL < 0)
                    throw new Exception("Indastede Km/l værdi er negativ og derfor ikke gyldig.");

                else
                    kmL = value; }
        }
        private double kmL;

        public driversLisenceEnum DriversLisence
        {
            get { return driversLisence; }
            set { driversLisence = value; }
        }
        private driversLisenceEnum driversLisence;
        public enum driversLisenceEnum
        {
            A,
            B,
            C,
            D,
            BE,
            CE,
            DE
        }

        public fuelTypeEnum FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        private fuelTypeEnum fuelType;

        public enum fuelTypeEnum
        {
            Diesel,
            Benzin
        }

        /// Engery class is calculated bassed on year of the car and the efficiancy in km/L.
        public engeryClassEnum EngeryClass
        {
            get { return engeryClass; }
        }
        private engeryClassEnum engeryClass;

        /// Returns the energy class in engeryClassEnum (A,B,C,D)
        public enum engeryClassEnum
        {
            A,
            B,
            C,
            D
        }

        private engeryClassEnum GetEnergyClass()
        {
            if (this.year < 2010)
            {
                if (this.fuelType is fuelTypeEnum.Diesel)
                {
                    if (this.kmL >= 23.0)
                    {
                        return engeryClassEnum.A;
                    }
                    else if (this.kmL < 23.0 && this.kmL >= 18.0)
                    {
                        return engeryClassEnum.B;
                    }
                    else if (this.kmL < 18.0 && this.kmL >= 13.0)
                    {
                        return engeryClassEnum.C;
                    }
                    else if (this.kmL < 13.0)
                    {
                        return engeryClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    if (this.kmL >= 18.0)
                    {
                        return engeryClassEnum.A;
                    }
                    else if (this.kmL < 18.0 && this.kmL >= 14.0)
                    {
                        return engeryClassEnum.B;
                    }
                    else if (this.kmL < 14.0 && this.kmL >= 10.0)
                    {
                        return engeryClassEnum.C;
                    }
                    else if (this.kmL < 10.0)
                    {
                        return engeryClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            else
            {
                if (this.fuelType is fuelTypeEnum.Diesel)
                {
                    if (this.kmL >= 25.0)
                    {
                        return engeryClassEnum.A;
                    }
                    else if (this.kmL < 25.0 && this.kmL >= 20.0)
                    {
                        return engeryClassEnum.B;
                    }
                    else if (this.kmL < 20.0 && this.kmL >= 15.0)
                    {
                        return engeryClassEnum.C;
                    }
                    else if (this.kmL < 15.0)
                    {
                        return engeryClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    if (this.kmL >= 20.0)
                    {
                        return engeryClassEnum.A;
                    }
                    else if (this.kmL < 20.0 && this.kmL >= 16.0)
                    {
                        return engeryClassEnum.B;
                    }
                    else if (this.kmL < 16.0 && this.kmL >= 12.0)
                    {
                        return engeryClassEnum.C;
                    }
                    else if (this.kmL < 12.0)
                    {
                        return engeryClassEnum.D;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        /// Returns the vehicle in a string with relivant information.
        public new virtual string ToString()
        {
            return String.Format(" {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: {7}\n {8}: {9}\n {10}: {11}\n {12}: {13}\n {14}: {15}\n {16}: {17}\n {18}: {19}",
                nameof(this.Name),
                this.Name,
                nameof(this.Km),
                this.Km,
                nameof(this.RegistrationNumber),
                "**" + this.RegistrationNumber.Substring(2, 3) + "**",
                nameof(this.Year),
                this.Year,
                nameof(this.NewPrice),
                this.NewPrice,
                nameof(this.Towbar),
                this.Towbar,
                nameof(this.EngineSize),
                this.EngineSize,
                nameof(this.kmL),
                this.kmL,
                nameof(this.DriversLisence),
                this.DriversLisence,
                nameof(this.FuelType),
                this.FuelType,
                nameof(this.EngeryClass),
                this.EngeryClass
                );
        }

        internal Auction Auction
        {
            get => default;
            set
            {
            }
        }
    }
}