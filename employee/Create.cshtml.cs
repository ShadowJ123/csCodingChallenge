using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rezor_sample_EF.Models;

namespace Rezor_sample_EF.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly Rezor_sample_EF.Models.TrainingContext _context;

        public CreateModel(Rezor_sample_EF.Models.TrainingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Emp Emp { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Emps.Add(Emp);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
