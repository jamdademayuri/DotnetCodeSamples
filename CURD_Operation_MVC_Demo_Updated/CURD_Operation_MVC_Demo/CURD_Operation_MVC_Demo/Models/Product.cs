using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace CURD_Operation_MVC_Demo.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        [Required(ErrorMessage ="Product Name is required")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Product Name must be between 5 and 25 characters.")]
        public string ProductName { get; set; }
        
        public int CategoryId { get; set; }

        // Navigation property
        public virtual Category Category { get; set; }
    }
}