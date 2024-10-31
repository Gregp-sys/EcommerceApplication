using Ecommerce1.Models;
using Ecommerce1.Views.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

public class CartController : Controller
{
    private readonly UserManager<AppUsers> _userManager;
    private readonly string _connectionString;

    public CartController(UserManager<AppUsers> userManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    // Method to get or create a new shopping session
    private async Task<int> GetOrCreateSessionAsync(string userId)
    {
        int? sessionId;

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();
            SqlCommand sessionCommand = new SqlCommand(
                "SELECT TOP 1 Id_Shop_Session FROM ShoppingSessions WHERE Id_AppUser = @UserId AND IsActive = 1",
                connection);
            sessionCommand.Parameters.AddWithValue("@UserId", userId);

            sessionId = (int?)await sessionCommand.ExecuteScalarAsync();

            if (sessionId == null)
            {
                SqlCommand createSessionCommand = new SqlCommand(
                    @"INSERT INTO ShoppingSessions (Id_AppUser, Created, IsActive)
                      OUTPUT INSERTED.Id_Shop_Session
                      VALUES (@UserId, GETDATE(), 1)", connection);
                createSessionCommand.Parameters.AddWithValue("@UserId", userId);

                sessionId = (int)await createSessionCommand.ExecuteScalarAsync();
            }
        }

        return sessionId.Value;
    }

    [HttpPost]
    public async Task<IActionResult> AddToCart(int productId, int quantity)
    {
        var userId = _userManager.GetUserId(User);
        if (userId == null)
        {
            return Unauthorized("You must be logged in to add items to the cart.");
        }

        int sessionId = await GetOrCreateSessionAsync(userId);

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();

            SqlCommand checkCartItemCommand = new SqlCommand(
                @"SELECT Quantity FROM CartItems 
                  WHERE Id_Shop_Session = @SessionId AND id_product = @ProductId",
                connection);
            checkCartItemCommand.Parameters.AddWithValue("@SessionId", sessionId);
            checkCartItemCommand.Parameters.AddWithValue("@ProductId", productId);

            var existingQuantity = (int?)await checkCartItemCommand.ExecuteScalarAsync();

            if (existingQuantity != null)
            {
                SqlCommand updateCartItemCommand = new SqlCommand(
                    @"UPDATE CartItems SET Quantity = Quantity + @Quantity 
                      WHERE Id_Shop_Session = @SessionId AND id_product = @ProductId",
                    connection);
                updateCartItemCommand.Parameters.AddWithValue("@Quantity", quantity);
                updateCartItemCommand.Parameters.AddWithValue("@SessionId", sessionId);
                updateCartItemCommand.Parameters.AddWithValue("@ProductId", productId);

                await updateCartItemCommand.ExecuteNonQueryAsync();
            }
            else
            {
                SqlCommand addCartItemCommand = new SqlCommand(
                    @"INSERT INTO CartItems (Id_Shop_Session, id_product, Quantity) 
                      VALUES (@SessionId, @ProductId, @Quantity)",
                    connection);
                addCartItemCommand.Parameters.AddWithValue("@SessionId", sessionId);
                addCartItemCommand.Parameters.AddWithValue("@ProductId", productId);
                addCartItemCommand.Parameters.AddWithValue("@Quantity", quantity);

                await addCartItemCommand.ExecuteNonQueryAsync();
            }
        }

        TempData["CartMessage"] = $"{quantity} item(s) added to your cart.";
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var userId = _userManager.GetUserId(User);
        if (userId == null)
        {
            return Unauthorized("You must be logged in to view the cart.");
        }

        int sessionId = await GetOrCreateSessionAsync(userId);

        List<CartItemViewModel> cartItems = new List<CartItemViewModel>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();

            SqlCommand cartCommand = new SqlCommand(
                @"SELECT c.id_cart, c.Quantity, s.Id_Shop_Session, p.Name, p.Price, (c.Quantity * p.Price) AS TotalPrice
                  FROM CartItems c 
                  JOIN Products p ON c.id_product = p.id_product
                  JOIN ShoppingSessions s ON c.Id_Shop_Session = s.Id_Shop_Session
                  WHERE c.Id_Shop_Session = @SessionId", connection);
            cartCommand.Parameters.AddWithValue("@SessionId", sessionId);

            SqlDataReader reader = await cartCommand.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                cartItems.Add(new CartItemViewModel
                {
                    Id_cart = reader.GetInt32(0),
                    Quantity = reader.GetInt32(1),
                    Id_Shopping_Session = reader.GetInt32(2),
                    ProductName = reader.GetString(3),
                    Price = reader.GetDecimal(4),
                    TotalPrice = reader.GetDecimal(5)
                });
            }
        }

        return View(cartItems);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateQuantity(int cartItemId, int quantity)
    {
        var userId = _userManager.GetUserId(User);
        if (userId == null)
        {
            return Unauthorized("You must be logged in to update items in the cart.");
        }

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();

            SqlCommand updateCommand = new SqlCommand(
                @"UPDATE CartItems SET Quantity = @Quantity 
                  WHERE id_cart = @CartItemId", connection);
            updateCommand.Parameters.AddWithValue("@Quantity", quantity);
            updateCommand.Parameters.AddWithValue("@CartItemId", cartItemId);

            await updateCommand.ExecuteNonQueryAsync();
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> DeleteItem(int cartItemId)
    {
        var userId = _userManager.GetUserId(User);
        if (userId == null)
        {
            return Unauthorized("You must be logged in to remove items from the cart.");
        }

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();

            SqlCommand deleteCommand = new SqlCommand(
                "DELETE FROM CartItems WHERE id_cart = @CartItemId", connection);
            deleteCommand.Parameters.AddWithValue("@CartItemId", cartItemId);

            await deleteCommand.ExecuteNonQueryAsync();
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> CompleteOrder()
    {
        var userId = _userManager.GetUserId(User);
        if (userId == null)
        {
            return Unauthorized("You must be logged in to complete the order.");
        }

        int sessionId = await GetOrCreateSessionAsync(userId);

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();

            SqlCommand completeSessionCommand = new SqlCommand(
                "UPDATE ShoppingSessions SET IsActive = 0 WHERE Id_Shop_Session = @SessionId",
                connection);
            completeSessionCommand.Parameters.AddWithValue("@SessionId", sessionId);

            await completeSessionCommand.ExecuteNonQueryAsync();
        }

        return RedirectToAction("Index", "Order", new { sessionId = sessionId });
    }
}
