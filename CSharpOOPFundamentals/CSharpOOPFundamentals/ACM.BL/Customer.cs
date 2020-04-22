using System;
using System.Reflection.Metadata.Ecma335;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName 
        {
            get => LastName + " " + FirstName;
        }

        private string _lastName;
        public string LastName 
        {
            get => _lastName;
            set => _lastName = value;
        }

    }
}
