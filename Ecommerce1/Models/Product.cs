using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce1.Data
{
    public class Product
    {
        [Key]
        public int Id_product { get; set; }

        public int? Id_discount { get; set; }  

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public string SKU { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }  
        public string Created { get; set; }
        public string Modified { get; set; }

        [ForeignKey("Id_discount")]
        public Discount Discount { get; set; } // Linked Discount

        public ICollection<Order> Orders { get; set; } //Linked Orders
    }
}
