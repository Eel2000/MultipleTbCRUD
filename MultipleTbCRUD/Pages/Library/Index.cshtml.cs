using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MultipleTbCRUD.Models;

namespace MultipleTbCRUD.Pages.Library
{
    public class IndexModel : PageModel
    {
        private readonly ModelContext _context;

        public IndexModel(ModelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await _context.Books
                .Include(b => b.Category)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}