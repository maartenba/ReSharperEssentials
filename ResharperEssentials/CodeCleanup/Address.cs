namespace ResharperEssentials.CodeCleanup
{
    public class Address
    {
        public Address(string street, string number, string postalCode, string location, string country)
        {
            Street = street;
            Number = number;
            PostalCode = postalCode;
            Location = location;
            Country = country;
        }

        public string Country { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string Location { get; set; }
    }
}