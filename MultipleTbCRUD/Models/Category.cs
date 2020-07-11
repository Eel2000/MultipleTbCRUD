using System.ComponentModel.DataAnnotations;

namespace MultipleTbCRUD.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        public string Designation { get; set; }
    }
}