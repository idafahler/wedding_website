using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wedding_website.Models;
using wedding_website.Services;

namespace wedding_website.Pages
{
    public class ConfirmationModel : PageModel
    {
        private readonly IGuestService _guestService;
        public ConfirmationModel(IGuestService guestService)
        {
            _guestService = guestService;
        }
        public Guest Guest { get; set; }
        public IActionResult OnGet(int id)
        {
            Guest = _guestService.GetGuest(id);

            if (Guest == null)
                return NotFound();
            return Page();
        }
    }
}
