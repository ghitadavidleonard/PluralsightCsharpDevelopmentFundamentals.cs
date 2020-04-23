namespace ACM.BL
{
    public class Address
    {
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLineOne { get; set; }
        public string StreetLineTwo { get; set; }

        public Address()
        {
        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public bool Validate()
        {
            if (PostalCode == null) return false;
            return true;
        }
    }
}