using wedding_website.Models;

namespace wedding_website.Services
{
    public class GuestService : IGuestService
    {
        private List<Guest> guests = [];

        public GuestService()
        {
        }

        public Guest[] GetAllGuests()
        {
            return guests.ToArray();
        }
        
        //Method for getting next available Id, like identity Id
        private int GetNextAvailableId()
        {
            return guests.Count == 0 ? 1 : guests.Max(g => g.Id) + 1;
        }

        public void AddGuest(Guest guest)
        {
            if (guest != null)
            {
                guest.Id = GetNextAvailableId();
                guests.Add(guest);
            }
        }

        public Guest? GetGuest(int id)
        {
            return guests.FirstOrDefault(g => g.Id == id);
        }
    }
}
