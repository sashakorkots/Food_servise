using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPages.Models;

namespace Food_servise.Pages_Restrants
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesContext _context;

        public CreateModel(RazorPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Restrant Restrant { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Restrant.Add(Restrant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
