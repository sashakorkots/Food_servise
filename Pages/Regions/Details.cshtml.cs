using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace Food_servise.Pages_Regions
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesContext _context;

        public DetailsModel(RazorPagesContext context)
        {
            _context = context;
        }

        public Region Region { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Region = await _context.Region
                .Include(r => r.CourierOfRegion)
                .Include(r => r.RestrantOfRegion).FirstOrDefaultAsync(m => m.Id == id);

            if (Region == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
