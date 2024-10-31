using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce1.Data
{
    public class Cart_item

    {

        [Key]
        public int Id_cart { get; set; }
        public int Id_Shop_Session { get; set; }
        public int Id_product { get; set; }

        [Required]
       
        public int Quantity { get; set; }
        public string? Created { get; set; }
        public string? Modified { get; set; }


        [ForeignKey("Id_Shop_Session")]
        public Shopping_Session Shopping_Session { get; set; }
       
        [ForeignKey("Id_product")]
        public Product Product { get; set; }


    }
}
