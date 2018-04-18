using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityWebSite.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(100)]
        public string ProductName { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public ICollection<File> Files { get; set; }
    }
}