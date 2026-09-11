using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace wedding_website.Models
{
    public class Guest
    {
        [BindNever] //Id is set in code-behind, not by user
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name needs to be between 2 - 50 characters.")]
        [Display(Name = "First name*")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(70, MinimumLength = 2, ErrorMessage = "Name needs to be between 2 - 70 characters.")]
        [Display(Name = "Last name*")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Submit a correct email address")]
        [Display(Name = "Email*")]
        public string Email { get; set; }

        [Display(Name = "I will attend ")]
        public bool Attendance { get; set; }

        [StringLength(100, ErrorMessage = "Message can be at most 100 characters.")]
        [Display(Name = "Message (optional)")]
        public string? Message { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
