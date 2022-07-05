using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Models
{
    public class Product
    {

        public int Id {get; set; }
        [Display(Name="Product Name")]
        [Required]
        public string ProductName { get; set; }

        [Display(Name = "Product Price")]
        [Required]
        public int ProductPrice { get; set; }
        [Display(Name = "Product Image")]
        
        public string ProductImage { get; set; }
        
        [Display(Name = "Product Star")]
        public int ProductStar { get; set; }


    }
}
