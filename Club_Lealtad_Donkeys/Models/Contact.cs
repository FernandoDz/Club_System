namespace Club_Lealtad_Donkeys.Models
{
    public class Club
    {
        public string Id { get; set; }
    }

    public class Scheme
    {
        public string Id { get; set; }
        public Club Club { get; set; }
    }

    public class Account
    {
        public string Id { get; set; }
        public Scheme Scheme { get; set; }
    }

    public class Address
    {
        public string Address1 { get; set; }
        public string CellPhoneNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string PostCode { get; set; }
        public string StateProvinceRegion { get; set; }
        public string Type { get; set; }
    }

    public class Contact
    {
        public string Id { get; set; }
        public List<Address> Addresses { get; set; }

        public Account Account { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string MiddleName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
