using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BLAGA_ANEMONA_LAB2.Data;
using BLAGA_ANEMONA_LAB2.Models;

namespace BLAGA_ANEMONA_LAB2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BLAGA_ANEMONA_LAB2.Data.BLAGA_ANEMONA_LAB2Context _context;

        public CreateModel(BLAGA_ANEMONA_LAB2.Data.BLAGA_ANEMONA_LAB2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID","PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
