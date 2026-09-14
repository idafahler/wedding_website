using wedding_website.Models;

namespace wedding_website.Services
{
    public interface IGuestService
    {
        void AddGuest(Guest guest);
        Guest[] GetAllGuests();
        Guest? GetGuest(int id);
        void UpdateGuest(Guest guest);
        bool DeleteGuest(int id);
    }
}