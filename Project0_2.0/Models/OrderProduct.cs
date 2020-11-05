using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class OrderProduct
    {

        [Required]
        [ForeignKey("FK_ProductOrderProd")]
        public int ProductId { get; set; }
        [Key]
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
        internal OrderProduct
           (int productId, int orderId, int quantity)
        {
            ProductId = productId;
            OrderId = orderId;
            Quantity = quantity;
        }
        public OrderProduct
            (Order order, Product product, int quantity) 
            : this(order.OrderId, product.ProductId, quantity)
        {
            Product = product;
            Order = order;
        }
    }
}
