using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce1.Models;

namespace Ecommerce1.Data
{
    public class Shopping_Session
    {
        [Key]
        public int Id_Shop_Session { get; set; }

        public int Id_AppUser { get; set; } // Foreign key for AppUsers

        [Required]
        public decimal Total_price { get; set; }

        public DateTime Created { get; set; } 
        public DateTime? Modified { get; set; }
        public bool IsActive { get; set; }// check if the session is active

        // Navigation property

        [ForeignKey("Id_AppUser")]
        public virtual AppUsers AppUser { get; set; }

      
    }
}
