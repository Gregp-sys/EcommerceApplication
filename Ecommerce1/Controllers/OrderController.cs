using Ecommerce1.Models;
using Ecommerce1.Views.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

public class OrderController : Controller
{
    private readonly UserManager<AppUsers> _userManager;
    private readonly string _connectionString;

    public OrderController(UserManager<AppUsers> userManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    [HttpGet]
    public async Task<IActionResult> Index(int sessionId)
    {
        var userId = _userManager.GetUserId(User);
        if (userId == null)
        {
            return Unauthorized("You must be logged in to view the order.");
        }

        // Retrieve order items for the specified session
        List<CartItemViewModel> orderItems = new List<CartItemViewModel>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();

            SqlCommand orderCommand = new SqlCommand(
                @"SELECT c.id_cart, c.Quantity, p.Name, p.Price, (c.Quantity * p.Price) AS TotalPrice
                  FROM CartItems c 
                  JOIN Products p ON c.id_product = p.id_product
                  WHERE c.Id_Shop_Session = @SessionId", connection);
            orderCommand.Parameters.AddWithValue("@SessionId", sessionId);

            SqlDataReader reader = await orderCommand.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                orderItems.Add(new CartItemViewModel
                {
                    Id_cart = reader.GetInt32(0),
                    Quantity = reader.GetInt32(1),
                    ProductName = reader.GetString(2),
                    Price = reader.GetDecimal(3),
                    TotalPrice = reader.GetDecimal(4)
                });
            }
        }

        return View(orderItems);
    }

    [HttpPost]
    public async Task<IActionResult> CompleteOrder(int sessionId)
    {
        var userId = _userManager.GetUserId(User);
        if (userId == null)
        {
            return Unauthorized("You must be logged in to complete the order.");
        }

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();

            // Mark the session as inactive to finalize the order
            SqlCommand completeOrderCommand = new SqlCommand(
                "UPDATE ShoppingSessions SET IsActive = 0 WHERE Id_Shop_Session = @SessionId",
                connection);
            completeOrderCommand.Parameters.AddWithValue("@SessionId", sessionId);

            await completeOrderCommand.ExecuteNonQueryAsync();
        }

        TempData["OrderMessage"] = "Your order has been successfully completed!";
        return RedirectToAction("Confirmation");
    }

    [HttpGet]
    public IActionResult Confirmation()
    {
        return View();
    }
}
