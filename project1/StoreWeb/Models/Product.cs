using System.ComponentModel.DataAnnotations;

namespace StoreWeb.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}