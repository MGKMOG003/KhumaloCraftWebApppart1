using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KhumaloCraftWebApp.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Availability { get; set; }

        [Required]
        public double Rating { get; set; }

        [Required]
        public int SellerID { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
