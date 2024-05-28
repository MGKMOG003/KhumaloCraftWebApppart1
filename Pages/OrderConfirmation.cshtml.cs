using Microsoft.AspNetCore.Mvc.RazorPages;
using KhumaloCraftWebApp.Data;
using KhumaloCraftWebApp.Models;

namespace KhumaloCraftWebApp.Pages
{
    public class OrderConfirmationModel : PageModel
    {
        public Order Order { get; set; }

        public void OnGet(Order order)
        {
            Order = order;
        }
    }
}
