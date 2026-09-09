using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wedding_website.Models;
using wedding_website.Services;

namespace wedding_website.Pages
{
    public class RsvpModel : PageModel
    {
        private readonly IGuestService _guestService;
        public RsvpModel(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [BindProperty]
        public Guest Guest { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) 
                return Page();

            _guestService.AddGuest(Guest);
            return RedirectToPage("./Confirmation", new { id = Guest.Id });
        }
    }
}
