using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Club_Lealtad_Donkeys.Models
{
    public class Club
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }
    }

    public class Scheme
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Club")]
        public Club Club { get; set; }
    }

    public class Account
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Scheme")]
        public Scheme Scheme { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("Address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("CellPhoneNumber")]
        public string CellPhoneNumber { get; set; }

        [JsonPropertyName("City")]
        public string City { get; set; }

        [JsonPropertyName("Country")]
        public string Country { get; set; }

        [JsonPropertyName("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("PostCode")]
        public string PostCode { get; set; }

        [JsonPropertyName("StateProvinceRegion")]
        public string StateProvinceRegion { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }
    }

    public class Contact
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Account")]
        public Account Account { get; set; }

        [JsonPropertyName("Addresses")]
        public List<Address> Addresses { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonPropertyName("Gender")]
        public string Gender { get; set; }

        [JsonPropertyName("MiddleName")]
        public string MiddleName { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Password")]
        public string Password { get; set; }

        [JsonPropertyName("UserName")]
        public string UserName { get; set; }
    }

    public class MemberAccount
    {
        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }
    }
}


