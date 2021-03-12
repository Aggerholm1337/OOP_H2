using System;
using System.Collections.Generic;

namespace Vehicle_Program
{
    class Program
    {
        static void Main(string[] args)
        {


            string Commercial_PassengerCar_name = "SEAT Leon";
            double Commercial_PassengerCar_km = 146.152;
            string Commercial_PassengerCar_registrationNumber = "BD76543";
            int Commercial_PassengerCar_year = 2012;
            double Commercial_PassengerCar_newPrice = 10000.0;
            double Commercial_PassengerCar_engineSize = 10.0;
            double Commercial_PassengerCar_kmL = 20.0;
            var Commercial_PassengerCar_fuelType = Vehicle.fuelTypeEnum.Benzin;
            int Commercial_PassengerCar_seats = 2;
            bool Commercial_PassengerCar_safetyBar = true;
            double Commercial_PassengerCar_loadCapacity = 400.0;

            PassengerCar.storageDimensionsStructure Commercial_PassengerCar_sd;
            Commercial_PassengerCar_sd.height = 20.0;
            Commercial_PassengerCar_sd.width = 50.0;
            Commercial_PassengerCar_sd.depth = 25.0;

            //Console.WriteLine("Commercial PassengerCar:");
            CommercialPassengerCar SEAT_Leon_Commercial = new CommercialPassengerCar(Commercial_PassengerCar_name, 
                Commercial_PassengerCar_km, 
                Commercial_PassengerCar_registrationNumber, 
                Commercial_PassengerCar_year, 
                Commercial_PassengerCar_newPrice,
                Commercial_PassengerCar_engineSize, 
                Commercial_PassengerCar_kmL, 
                Commercial_PassengerCar_fuelType, 
                Commercial_PassengerCar_seats,
                Commercial_PassengerCar_sd, 
                Commercial_PassengerCar_safetyBar, 
                Commercial_PassengerCar_loadCapacity);
            //Console.WriteLine(SEAT_Leon_Commercial.ToString() + "\n");

            string Private_PassengerCar_name = "Hyundai i10";
            double Private_PassengerCar_km = 87.356;
            string Private_PassengerCar_registrationNumber = "AH56955";
            int Private_PassengerCar_year = 2014;
            double Private_PassengerCar_newPrice = 12000.0;
            bool Private_PassengerCar_towbar = true;
            double Private_PassengerCar_engineSize = 4.0;
            double Private_PassengerCar_kmL = 17.0;
            Vehicle.fuelTypeEnum Private_PassengerCar_fuelType = Vehicle.fuelTypeEnum.Benzin;
            int Private_PassengerCar_seats = 5;
            bool Private_PassengerCar_isoFix = true;

            PassengerCar.storageDimensionsStructure Private_PassengerCar_sd;
            Private_PassengerCar_sd.height = 30.0;
            Private_PassengerCar_sd.width = 60.0;
            Private_PassengerCar_sd.depth = 35.0;

            //Console.WriteLine("Private PassengerCar:");
            PrivatePassengerCar Hyundai_i10_Private = new PrivatePassengerCar(Private_PassengerCar_name,
                Private_PassengerCar_km,
                Private_PassengerCar_registrationNumber,
                Private_PassengerCar_year,
                Private_PassengerCar_newPrice,
                Private_PassengerCar_towbar,
                Private_PassengerCar_engineSize,
                Private_PassengerCar_kmL,
                Private_PassengerCar_fuelType,
                Private_PassengerCar_seats,
                Private_PassengerCar_sd,
                Private_PassengerCar_isoFix);
            //Console.WriteLine(Hyundai_i10_Private.ToString() + "\n");


            string Truck_name = "Volvo VNR";
            double Truck_km = 87.356;
            string Truck_registrationNumber = "AH56955";
            int Truck_year = 2014;
            double Truck_newPrice = 12000.0;
            bool Truck_towbar = true;
            double Truck_engineSize = 4.0;
            double Truck_kmL = 17.0;
            Vehicle.fuelTypeEnum Truck_fuelType = Vehicle.fuelTypeEnum.Diesel;
            int Truck_seats = 2;
            double Truck_loadCapacity = 32.000;
            double Truck_truckHeight = 2.90;
            double Truck_truckWeight = 750;
            double Truck_truckLength = 3.10;

            //Console.WriteLine("Private PassengerCar:");
            Truck Volvo_VNR = new Truck(Truck_name,
                Truck_km,
                Truck_registrationNumber,
                Truck_year,
                Truck_newPrice,
                Truck_towbar,
                Truck_engineSize,
                Truck_kmL,
                Truck_fuelType,
                Truck_seats,
                Truck_loadCapacity,
                Truck_truckHeight,
                Truck_truckWeight,
                Truck_truckLength);
            //Console.WriteLine(Hyundai_i10_Private.ToString() + "\n");



            string Bus_name = "Bus Extreme";
            double Bus_km = 87.356;
            string Bus_registrationNumber = "AH56955";
            int Bus_year = 2014;
            double Bus_newPrice = 12000.0;
            bool Bus_towbar = true;
            double Bus_engineSize = 4.0;
            double Bus_kmL = 17.0;
            Vehicle.fuelTypeEnum Bus_fuelType = Vehicle.fuelTypeEnum.Diesel;
            int Bus_passengerSeats = 30;
            int Bus_sleepingSpots = 30;
            bool Bus_toilets = true;
            double Bus_busHeight = 2.10;
            double Bus_busWeight = 900;
            double Bus_busLength = 4.10;

            //Console.WriteLine("Private PassengerCar:");
            Bus Bus_Extreme = new Bus(Bus_name,
                Bus_km,
                Bus_registrationNumber,
                Bus_year,
                Bus_newPrice,
                Bus_towbar,
                Bus_engineSize,
                Bus_kmL,
                Bus_fuelType,
                Bus_passengerSeats,
                Bus_sleepingSpots,
                Bus_toilets,
                Bus_busHeight,
                Bus_busWeight,
                Bus_busLength);



            string BuyerUser_Firstname = "Michael";
            string BuyerUser_Lastname = "Aggerholm";
            string BuyerUser_Address = "Hellekisten 223";
            int BuyerUser_PhoneNumber = 20241530;
            int BuyerUser_ZipCode = 9230;
            decimal BuyerUser_Balance = 5000M;
            int BuyerUser_CprNumber = 1302921234;

            privateUser Michael = new privateUser(BuyerUser_Firstname,
                BuyerUser_Lastname,
                BuyerUser_Address,
                BuyerUser_PhoneNumber,
                BuyerUser_ZipCode,
                BuyerUser_Balance,
                BuyerUser_CprNumber);


            List<Vehicle> newVehicle = new List<Vehicle>();
            newVehicle.Add(SEAT_Leon_Commercial);
            newVehicle.Add(Hyundai_i10_Private);
            newVehicle.Add(Volvo_VNR);
            newVehicle.Add(Bus_Extreme);

            foreach (Vehicle vehicle in newVehicle)
            {
                Console.WriteLine(vehicle.ToString() + "\n");
            }

            List<User> newUser = new List<User>();
            newUser.Add(Michael);

            foreach (User user in newUser)
            {
                Console.WriteLine(user.ToString() + "\n");
            }

            AuctionHouse.SetForSale(Volvo_VNR, Michael, 5500M);

            //AuctionHouse A = new AuctionHouse();
            //A.V.Add(SEAT_Leon_Commercial);
            //foreach (Vehicle vi in A.V)
            //{
            //    Console.WriteLine(vi.ToString() + "\n");
            //}

            //A.SetForSale(Michael, Michael.bidNotification);
        }
    }
}