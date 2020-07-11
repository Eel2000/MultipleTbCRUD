using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MultipleTbCRUD.Models;

namespace MultipleTbCRUD.Pages.Library
{
    public class CreateModel : CategoryNamePageModel
    {

        private readonly ModelContext _context;

        public CreateModel(ModelContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateCategoryDropDownList(_context);

            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnPost()
        {
            var emptyBook = new Book();

            if(await TryUpdateModelAsync<Book>(emptyBook,"book",
                s => s.ID,s => s.CategoryID, s => s.Title, s => s.Pages))
            {
                await _context.Books.AddAsync(emptyBook);
                await _context.SaveChangesAsync();

                RedirectToPage("./Index");
            }

            PopulateCategoryDropDownList(_context, emptyBook.CategoryID);
            return Page();
        }

    }
}