using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KhumaloCraftWebApp.Models;
using KhumaloCraftWebApp.Data;

namespace KhumaloCraftWebApp.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ContactModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactMessage ContactMessage { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ContactMessages.Add(ContactMessage);
            _context.SaveChanges();

            return RedirectToPage("ContactConfirmation");
        }
    }
}
