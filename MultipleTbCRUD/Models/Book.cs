using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleTbCRUD.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Pages { get; set; }

        
        public int CategoryID { get; set; }


        public Category Category { get; set; }
    }
}
