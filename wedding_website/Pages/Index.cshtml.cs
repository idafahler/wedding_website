using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wedding_website.Models;
using wedding_website.Services;

namespace wedding_website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IEventService _eventService;
        public IndexModel(IEventService eventService)
        {
            _eventService = eventService;
        }

        public Event[] Events { get; set; } = [];
        public Event Ceremony => Events.First();
        public void OnGet()
        {
            Events = _eventService.GetAllEvents();
        }
    }
}
