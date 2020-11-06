﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDB.Models
{
    public class CartItem
    {
        [Key]
        public int CartInventoryId { get; set; }
        [ForeignKey("FK_CICart")]
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        [ForeignKey("FK_CartProd")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }

    }
}
