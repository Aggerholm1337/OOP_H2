using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Program
{
    class AuctionHouse
    {
        public static Auction SetForSale (Vehicle vehicleType, ISellerModel seller, decimal myPrice)
        {
            Auction auction = new Auction(vehicleType, seller, myPrice);
            auction.Vehicle.ToString();

            return auction;
        }

        public static int SetForSale(ISellerModel s)
        {
            throw new NotImplementedException();
        }

        public static int SetForSale(Vehicle V, ISellerModel s, Func<string> bidNotification)
        {
            bidNotification();
            Console.WriteLine(s.ZipCode);
            throw new NotImplementedException();
        }

        public static int ReceiveBid(ISellerModel buyer, int auctionNumber, decimal bid)
        {
            throw new NotImplementedException();
        }

        public static int AcceptBid(ISellerModel seller, int auctionNumber)
        {
            throw new NotImplementedException();
        }
    }
}