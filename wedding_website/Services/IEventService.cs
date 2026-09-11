using wedding_website.Models;

namespace wedding_website.Services
{
    public interface IEventService
    {
        Event[] GetAllEvents();
    }
}