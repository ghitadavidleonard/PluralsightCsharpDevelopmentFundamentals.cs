using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ACM.BL
{
    public class Customer
    {
        public static int InstanceCount { get; set; }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
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

        public Customer() {}
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        public Customer Retrieve(int customerId)
        {

            return new Customer();
        }

        /// <summary>
        /// Retrieve all customers.
        /// </summary>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customers.
        /// </summary>
        public bool Save()
        {

            return true;
        }

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
