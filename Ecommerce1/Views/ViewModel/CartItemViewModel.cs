namespace Ecommerce1.Views.ViewModel
{
    public class CartItemViewModel
    {
        public int Id_cart { get; set; }
        public int Id_Shopping_Session { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

