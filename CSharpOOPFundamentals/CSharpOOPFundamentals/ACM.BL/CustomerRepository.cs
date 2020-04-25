using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    // Call an Insert Stored Procedure
                }
                else
                {
                    // Call an Update Stored Procedure
                    success = false;
                }
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}