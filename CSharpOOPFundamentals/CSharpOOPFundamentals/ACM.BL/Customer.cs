using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace ACM.BL
{
    public class Customer
    {
        public static int InstanceCount { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }
        public string FirstName { get; set; }
        public string FullName 
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        private string _lastName;
        public string LastName 
        {
            get => _lastName;
            set => _lastName = value;
        }

        public Customer() : this(0) {}
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public override string ToString() => $"{FullName}";

        /// <summary>
        /// Validates the customer data
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
