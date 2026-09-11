using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wedding_website.Models;
using wedding_website.Services;

namespace wedding_website.Pages
{
    public class EditGuestModel : PageModel
    {
        private readonly IGuestService _guestService;
        public EditGuestModel(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [BindProperty]
        public Guest Guest { get; set; }

        public IActionResult OnGet(int id)
        {
            Guest = _guestService.GetGuest(id);
            if (Guest == null)
                return NotFound();
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
                return Page();

            Guest.Id = id;
            _guestService.UpdateGuest(Guest);
            return RedirectToPage("./Guests");
        }
    }
}
