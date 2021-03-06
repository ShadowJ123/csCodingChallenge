﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_sample_EF.Models;

namespace Rezor_sample_EF.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly Rezor_sample_EF.Models.TrainingContext _context;

        public DetailsModel(Rezor_sample_EF.Models.TrainingContext context)
        {
            _context = context;
        }

        public Emp Emp { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Emp = await _context.Emps.FirstOrDefaultAsync(m => m.Empno == id);

            if (Emp == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
