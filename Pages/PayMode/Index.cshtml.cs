using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using System.Collections.Generic; 
using System.Threading.Tasks;     

namespace SupermarketWEB.Pages.PayModes
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public List<SupermarketWEB.Models.PayMode> PayMode { get; set; } = new List<SupermarketWEB.Models.PayMode>();

        public async Task OnGetAsync()
        {
            if (_context.PayModes != null)
            {
                PayMode = await _context.PayModes.ToListAsync();
            }
        }
    }
}