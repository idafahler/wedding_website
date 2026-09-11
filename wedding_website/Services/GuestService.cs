using wedding_website.Models;

namespace wedding_website.Services
{
    public class GuestService : IGuestService
    {
        private readonly List<Guest> _guests =
        [
            new Guest { Id = 1, FirstName = "Emily", LastName = "Carter", Email = "emily.carter@example.com", Attendance = true, Message = "So happy for you both! Can't wait to celebrate." },
            new Guest { Id = 2, FirstName = "Thomas", LastName = "Whitfield", Email = "t.whitfield@example.com", Attendance = true, Message = null },
            new Guest { Id = 3, FirstName = "Amara", LastName = "Okonkwo", Email = "amara.okonkwo@example.com", Attendance = false, Message = "Sadly I'll be abroad that week, but I'll be thinking of you." },
            new Guest { Id = 4, FirstName = "Lucas", LastName = "Bergström", Email = "lucas.bergstrom@example.com", Attendance = true, Message = "Allergies: Nuts and seafood" }
        ];

        public Guest[] GetAllGuests()
        {
            return _guests.ToArray();
        }
        
        //Method for getting next available Id, like identity Id
        private int GetNextAvailableId()
        {
            return _guests.Count == 0 ? 1 : _guests.Max(g => g.Id) + 1;
        }

        public void AddGuest(Guest guest)
        {
            if (guest != null)
            {
                guest.Id = GetNextAvailableId();
                _guests.Add(guest);
            }
        }

        public Guest? GetGuest(int id)
        {
            return _guests.FirstOrDefault(g => g.Id == id);
        }

        public void UpdateGuest(Guest guest)
        {
            var existing = GetGuest(guest.Id);
            if (existing == null) 
                return;

            existing.FirstName = guest.FirstName;
            existing.LastName = guest.LastName;
            existing.Email = guest.Email;
            existing.Attendance = guest.Attendance;
            existing.Message = guest.Message;
        }

        public bool DeleteGuest(int id)
        {
            var guest = GetGuest(id);
            if (guest == null) 
                return false;

            return _guests.Remove(guest);
        }
    }
}
