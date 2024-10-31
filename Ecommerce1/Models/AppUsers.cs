using Ecommerce1.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce1.Models
{
    public class AppUsers : IdentityUser<int>
    {
        [Key]
        public int Id_Appuser { get; set; } // Custom primary key for AppUsers

        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        public DateTime? Created { get; set; } = DateTime.UtcNow;

        public virtual ICollection<Shopping_Session>? ShoppingSessions { get; set; }
        public virtual ICollection<Order_Details>? OrderDetails { get; set; }

        public void SetPassword(string password, IPasswordHasher<AppUsers> passwordHasher)
        {
            PasswordHash = passwordHasher.HashPassword(this, password);
        }

        // Override the Id property to use the custom primary key
        public override int Id => Id_Appuser; // Ensure that the IdentityUser uses Id_Appuser as its ID
    }
}
