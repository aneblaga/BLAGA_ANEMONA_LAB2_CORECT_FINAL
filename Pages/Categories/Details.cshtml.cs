using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BLAGA_ANEMONA_LAB2.Data;
using BLAGA_ANEMONA_LAB2.Models;

namespace BLAGA_ANEMONA_LAB2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly BLAGA_ANEMONA_LAB2.Data.BLAGA_ANEMONA_LAB2Context _context;

        public DetailsModel(BLAGA_ANEMONA_LAB2.Data.BLAGA_ANEMONA_LAB2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
