using Pitney_Bowes___task.Model;

namespace Pitney_Bowes___task.Service
{
    public class AdressbookService : IAdressbookService
    {
        private List<Address> AddressesList = new List<Address>();
        //HTTPGET
        public void AddAddress(Address address)
        {
            AddressesList.Add(address);
        }

        public IEnumerable<Address> GetAddressesInCity(string city) => AddressesList
            .Where(a => a.CityName == city);

        //HTTPPOST
        public Address? GetLastAddress()
        {
            if(AddressesList.Count == 0)
            {
                return null;
            }
            return AddressesList.Last();
        }

        
    }
}
