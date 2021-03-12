using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Vehicle_Program
{
    abstract class User : IBuyerModel, ISellerModel
    {
        protected User(string firstName,
        string lastName,
        string address,
        int phoneNumber,
        int zipCode,
        decimal balance)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.ZipCode = zipCode;
            this.Balance = balance;
        }

        // FirstName returnere en fejlbesked via NullException hvis input er null.
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }
                firstName = value;
            }
        }
        private string firstName;

        // LastName returnere en fejlbesked via NullException hvis input er null.
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }
                lastName = value;
            }
        }
        private string lastName;

        // Address returnere en fejlbesked via NullException hvis input er null.
        public string Address
        {
            get { return address; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(value)}");
                }
                address = value;
            }
        }
        private string address;

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                var r = new Regex(@"^\d{8}$");
                if (!r.IsMatch(value.ToString()))
                    throw new Exception("Telefon nummer er ikke gyldigt!");

                else
                    phoneNumber = value;
            }
        }
        private int phoneNumber;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private decimal balance;

        public int ZipCode
        {
            get { return zipCode; }
            set
            {
                var r = new Regex(@"^\d{4}$");
                if (!r.IsMatch(value.ToString()))
                    throw new Exception("Zip Code er ikke gyldigt!");

                else
                    zipCode = value;
            }
        }
        private int zipCode;

        public string bidNotification()
        {
            throw new NotImplementedException();
        }

        public new virtual string ToString()
        {
            return String.Format("\n {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}: {7}\n {8}: {9}\n {10}: {11}",
                nameof(this.FirstName),
                this.FirstName,
                nameof(this.LastName),
                this.LastName,
                nameof(this.Address),
                this.Address,
                nameof(this.PhoneNumber),
                this.PhoneNumber,
                nameof(this.ZipCode),
                this.ZipCode,
                nameof(this.Balance),
                this.Balance.ToString()
                );
        }
    }

    class corporateUser : User
    {
        public corporateUser(string firstName,
        string lastName,
        string address,
        int phoneNumber,
        int zipCode,
        decimal balance) : base(firstName, lastName, address, phoneNumber, zipCode, balance)
        {
            this.CVRNumber = cvrNumber;
            this.Credit = credit;
        }
        public int CVRNumber
        {
            get { return cvrNumber; }
            set { cvrNumber = value; }
        }
        private int cvrNumber;

        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        private int credit;

        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}\n {2}: {3}",
                nameof(this.CVRNumber),
                this.CVRNumber,
                nameof(this.Credit),
                this.Credit.ToString()
                );
        }
    }

    class privateUser : User
    {
        public privateUser(string firstName,
        string lastName,
        string address,
        int phoneNumber,
        int zipCode,
        decimal balance,
        int CPRNumber) : base(firstName, lastName, address, phoneNumber, zipCode, balance)
        {
            this.cprNumber = CPRNumber;
        }
        public int CPRNumber
        {
            get { return cprNumber; }
            set { cprNumber = value; }
        }
        private int cprNumber;

        public override string ToString()
        {
            return base.ToString() + String.Format("\n {0}: {1}",
                nameof(this.cprNumber),
                this.cprNumber.ToString()
                );
        }
    }
}
