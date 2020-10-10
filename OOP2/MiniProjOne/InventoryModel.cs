namespace MiniProjOne
{
    public class InventoryModel
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

    public class VehicleModel : InventoryModel
    {
        public decimal Price { get; set; }
    }
    public class BookModel : InventoryModel
    {

    }
}
