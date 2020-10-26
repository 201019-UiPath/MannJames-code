using System;
using System.Collections.Generic;
using System.Text;
using Libraries;
using System.Collections.Concurrent;
using System.Dynamic;
using System.Linq;
using Models;
using System.ComponentModel;

namespace BLL
{
    class OrdProdFiltering
    {

        public OrdProdFiltering(List<Product> productList)
        {
            //make orders match customerid so all orders are listed
            //join orderid with customerid with products.orderid
            OrderLib orLib = new OrderLib();
            orLib.OrderProducts.Where(Products => Products.OrderID == 1)
                    .ToList()
                    .ForEach(Product => Console.WriteLine
                    (
                        $"{Product.ProductName} {Product.ProductType} {Product.ProductPrice} {Product.Quantity}"
                    ));
        }
    }
}
