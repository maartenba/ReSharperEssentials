namespace ResharperEssentials.CodeCleanup
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }

        public Customer(int id, string name, string street, string number, string postalCode, string location, string country)
        {
            Id = id;
            Name = name;
            Street = street;
            Number = number;
            PostalCode = postalCode;
            Location = location;
            Country = country;
        }

        public override string ToString()
        {
            // ReSharper disable once UseStringInterpolation
            return string.Format("{0}: {1}, {2}: {3}, {4}: {5}, {6}: {7}, {8}: {9}, {10}: {11}, {12}: {13}", 
                nameof(Id), Id, 
                nameof(Name), Name, 
                nameof(Street), Street, 
                nameof(Number), Number, 
                nameof(PostalCode), PostalCode,
                nameof(Location), Location,
                nameof(Country), Country);
        }
    }
}