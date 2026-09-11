using wedding_website.Models;

namespace wedding_website.Services
{
    public class EventService : IEventService
    {
        private readonly List<Event> events =
            [
                new Event ( 1, "The ceremony", new DateTime(2027, 6, 20, 15, 0, 0), "Rosewood Estate", "18 Willow Lane, Hampshire, England" ),
                new Event ( 2, "The reception", new DateTime(2027, 6, 20, 16, 30, 0), "Rosewood Estate", "18 Willow Lane, Hampshire, England" ),
                new Event ( 3, "Dinner", new DateTime(2027, 6, 20, 18, 00, 0), "Rosewood Estate", "18 Willow Lane, Hampshire, England" ),
                new Event ( 4, "First dance", new DateTime(2027, 6, 20, 20, 30, 0), "Rosewood Estate", "18 Willow Lane, Hampshire, England" )
            ];

        public Event[] GetAllEvents() => events.ToArray();
    }
}
