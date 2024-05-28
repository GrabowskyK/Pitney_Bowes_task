using Pitney_Bowes___task.Model;

namespace Pitney_Bowes___task.Service
{
    public interface IAdressbookService
    {
        void AddAddress(Address address);
        IEnumerable<Address> GetAddressesInCity(string city);
        Address? GetLastAddress();

        
    }
}