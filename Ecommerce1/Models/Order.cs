using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce1.Data
{
    public class Order
    {
        [Key]
        public int Id_Order { get; set; }
        public int Id_product { get; set; }
        [Required]
        public string Created { get; set; }
        public string Modified { get; set; }

        public ICollection<Order_Details> Order_Details { get; set; }//Linked Order_Details

        public ICollection<Payment> Payment { get; set; }//Linked payment

        [ForeignKey("Id_product")]
        public Product Product { get; set; }
    }
}
