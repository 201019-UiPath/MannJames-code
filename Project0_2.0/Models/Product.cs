using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }
        [ForeignKey("FK_ProductLocation")]
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
