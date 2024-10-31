using Microsoft.AspNetCore.Mvc;
using Ecommerce1.Data;
using Microsoft.EntityFrameworkCore; // Make sure to include the Product model

public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult ShoppingPage()
    {
        var products = _context.Products.Include(p => p.Discount).ToList(); // Include discount if needed
        return View(products);
    }
}
