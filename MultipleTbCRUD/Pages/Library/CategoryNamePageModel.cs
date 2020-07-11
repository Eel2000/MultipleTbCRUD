using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MultipleTbCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleTbCRUD.Pages.Library
{
    public class CategoryNamePageModel : PageModel
    {
        public SelectList CategoryNameSL { get; set; }

        public void PopulateCategoryDropDownList(ModelContext _context, object selectedCategory = null)
        {
            var CategoryQuery = from c in _context.Categories
                                orderby c.Designation //sort by designation
                                select c;

            CategoryNameSL = new SelectList(CategoryQuery.AsNoTracking(), "CategoryID", "Designation", selectedCategory);
        }
    }
}
