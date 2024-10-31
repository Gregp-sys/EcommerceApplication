using System.ComponentModel.DataAnnotations;

namespace Ecommerce1.Data
{
    public class Discount
    {
        [Key]
        public int Id_discount { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Percent { get; set; }
        public string Created { get; set; }
        public string Modified { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
