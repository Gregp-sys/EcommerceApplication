using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce1.Data
{
    public class Payment
    {
        [Key]
        public int Id_payments { get; set; }
        public int Id_Order { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string Provider { get; set; }
        public string Status { get; set; }
        public string Created { get; set; }
        public string Modified { get; set; }



        [ForeignKey("Id_Order")]
        public Order Orders
        { get; set; }

    }
}
