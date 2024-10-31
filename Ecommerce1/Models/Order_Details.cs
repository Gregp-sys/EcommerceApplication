using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce1.Models;

namespace Ecommerce1.Data
{
    public class Order_Details
    {
        [Key]
        public int Id_details { get; set; }


        public int Id_AppUser { get; set; }

        public int Id_Order { get; set; }

        
        

        [Required]
        public string Created { get; set; }

        public string Modified { get; set; }

        
        [ForeignKey("Id_Order")]
        public Order Orders { get; set; }



        [ForeignKey("Id_AppUser")]
        public AppUsers AppUsers { get; set; }

        
    }
}
