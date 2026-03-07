using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Models
{
    public struct Adress
    {
        private readonly string country;
        private readonly string city;
        private readonly string street;
        private readonly string district;
        private readonly string number;

        public Adress(string? Country, string City, string Street, string District, string Number)
        {
            country = Country != null ? Country : string.Empty;
            city = City;
            street = Street;
            district = District;
            number = Number;
        }

        public string Country => country;
        public string City => city;
        public string Street => street;
        public string District => district;
        public string Number => number;

        public override string ToString()
        {
            return $"{country} {city} {district} {street} {number}";
        }

        public static Adress ConvertToAddress(string input)
        {
            string[] inputParts = input.Split(' ');

            string inputCountry = inputParts[0] != null && inputParts[0] != string.Empty ? inputParts[0].Trim() : string.Empty;
            string inputCity = inputParts[1] != string.Empty ? inputParts[1].Trim() : string.Empty;
            string inputDistrict = inputParts[2] != string.Empty ? inputParts[2].Trim() : string.Empty;
            string inputStreet = inputParts[3] != string.Empty ? inputParts[3].Trim() : string.Empty;
            string inputNumber = inputParts[4] != string.Empty ? inputParts[4].Trim() : string.Empty;

            var address = new Adress
            (
                inputCountry,
                inputCity,
                inputDistrict,
                inputStreet,
                inputNumber
            );

            return address;
        }
    }
}
