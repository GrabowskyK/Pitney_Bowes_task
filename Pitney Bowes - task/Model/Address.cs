namespace Pitney_Bowes___task.Model
{
    public class Address
    {
        private static int _nextId = 1;
        public int Id { get; private set; }
        public string CityName { get; set; }
        public string ZipCode { get; set; }  
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string? FlatNumber { get; set; }

        public Address(string cityName, string zipCode, string street, string houseNumber, string? flatNumber)
        {
            Id = _nextId++;
            CityName = cityName;
            ZipCode = zipCode;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
        }
    }
}

