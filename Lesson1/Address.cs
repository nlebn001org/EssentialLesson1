using System;

namespace Lesson1
{
    class Address
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }

        public Address()
        {
        }

        public Address(int index, string country, string city, string street, int house, int apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public void getAll()
        {
            Console.WriteLine($"Index is: {Index},\nCountry is: {Country},\nCity is: {City},\nStreet is: {Street},\nHouse is: {House},\nApartment is: {Apartment}.\n");
        }

    }
}
