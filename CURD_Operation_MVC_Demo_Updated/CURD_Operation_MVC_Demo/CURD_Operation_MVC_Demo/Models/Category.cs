using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CURD_Operation_MVC_Demo.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Category Name is required")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Category Name must be between 5 and 25 characters.")]
        public string CategoryName { get; set; }

        // Navigation property
        public virtual ICollection<Product> Products { get; set; }
    }
}