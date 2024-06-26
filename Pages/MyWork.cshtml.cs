using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KhumaloCraftWebApp.Data;
using KhumaloCraftWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KhumaloCraftWebApp.Pages
{
    public class MyWorkModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public MyWorkModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
