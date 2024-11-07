using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Invoices
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<Invoice> Invoice { get; set; } = new List<Invoice>();

        public async Task OnGetAsync()
        {
            if (_context.Invoices != null)
            {
                Invoice = await _context.Invoices.ToListAsync();
            }
        }
    }
}