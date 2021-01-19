using System;
using System.Collections.Generic;
using System.Text;

namespace BankAreUSEFCore.Domain.Models
{
    class Address
    {
        public int Id { get; protected set; }
        public string Street { get; protected set; }
        public string City { get; protected set; }
        public string ZipCode { get; protected set; }


        public Address(string street, string city, string zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }

    }
}
