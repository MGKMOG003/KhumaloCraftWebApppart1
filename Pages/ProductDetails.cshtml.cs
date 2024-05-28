using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KhumaloCraftWebApp.Data;
using KhumaloCraftWebApp.Models;
using System.Threading.Tasks;

namespace KhumaloCraftWebApp.Pages
{
    public class ProductDetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ProductDetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task OnGetAsync(int id)
        {
            Product = await _context.Products.FirstOrDefaultAsync(m => m.ProductID == id);
        }
    }
}
