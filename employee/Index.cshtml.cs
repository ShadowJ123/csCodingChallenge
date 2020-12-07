using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_sample_EF.Models;

namespace Rezor_sample_EF.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly Rezor_sample_EF.Models.TrainingContext _context;

        public IndexModel(Rezor_sample_EF.Models.TrainingContext context)
        {
            _context = context;
        }

        public IList<Emp> Emp { get;set; }

        public async Task OnGetAsync()
        {
            Emp = await _context.Emps.ToListAsync();
        }
    }
}
