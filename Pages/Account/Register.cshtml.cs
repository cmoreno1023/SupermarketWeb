using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SupermarketContext _context;

        public RegisterModel(SupermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Verificar si el correo ya está registrado
            if (_context.Users.Any(u => u.Email == User.Email))
            {
                ModelState.AddModelError(string.Empty, "Email already exists.");
                return Page();
            }

            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Login");
        }
    }
}
