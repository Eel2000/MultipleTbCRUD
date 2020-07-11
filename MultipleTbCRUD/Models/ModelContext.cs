using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleTbCRUD.Models
{
    public class ModelContext : DbContext
    {

        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
