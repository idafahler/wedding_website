using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wedding_website.Models;
using wedding_website.Services;

namespace wedding_website.Pages.Admin
{
    public class GuestsModel : PageModel
    {
        private readonly IGuestService _guestService;
        public GuestsModel(IGuestService guestService)
        {
            _guestService = guestService;
        }
        public Guest[] Guests { get; set; } = [];
        public void OnGet()
        {
            Guests = _guestService.GetAllGuests();
        }
    }
}
