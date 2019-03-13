using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMovies.Models;
using RazorPagesMovie.Models;

namespace RazorPageMovies.Pages.Student
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageMovies.Models.Context _context;

        public IndexModel(RazorPageMovies.Models.Context context)
        {
            _context = context;
        }

        public IList<RazorPagesMovie.Models.Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
