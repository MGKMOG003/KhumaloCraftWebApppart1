using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KhumaloCraftWebApp.Data;
using KhumaloCraftWebApp.Models;
using System;
using System.Threading.Tasks;

namespace KhumaloCraftWebApp.Pages
{
    public class OrderModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public OrderModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Ensure OrderDate is set to the current date and time
            Order.OrderDate = DateTime.Now;

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("/OrderConfirmation", new { id = Order.OrderID });
        }
    }
}
