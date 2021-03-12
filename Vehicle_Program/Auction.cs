using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Program
{
    class Auction
    {
        public Auction(Vehicle vehicle, ISellerModel seller, decimal myPrice)
        {
            this.Bid = myPrice;
            this.Vehicle = vehicle;
            this.Seller = (User)seller;
        }

        public decimal Bid
        {
            get { return bid; }
            set { bid = value; }
        }
        private decimal bid;

        public Vehicle Vehicle
        {
            get;
        }
        private Vehicle vehicle;

        public User Seller
        {
            get;
        }
        private User seller;

        public User Buyer
        {
            get;
        }
        private User buyer;

        internal User User
        {
            get => default;
            set
            {
            }
        }
    }
}
