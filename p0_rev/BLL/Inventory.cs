using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;
using System.Dynamic;
using System.Linq;
using Libraries;

namespace BLL
{
    public class Inventory
    {
        //take from Libraries.Program
        //take order and product list from Libraries.Program
        //make them into functions
        //start UI for viewing data
        //then go to updating methods
        //create flowchart for client-side operations
        public void Inventories(){
            LocationLib lL = new LocationLib();
            Console.Out.WriteLine($"You chose Location {lL.loc1.LocationID} at");
            Console.Out.WriteLine($"{lL.loc1.Address} {lL.loc1.CityName} {lL.loc1.StateName} {lL.loc1.ZipCode}");
            Console.Out.WriteLine("------------------------------");
            ProductLib pL = new ProductLib();

            pL.ProductList.Where(Products => Products.LocationID == 1 && Products.Quantity > 0)
                .ToList()
                .ForEach(Products => Console.WriteLine
                (
                    $"There are {Products.Quantity} left of " +
                    $"{Products.ProductName} {Products.ProductType} $ {Products.ProductPrice}"
                ));
            Console.Out.WriteLine(" ");
            Console.Out.WriteLine("We also have");
            pL.ProductList.Where(Products => Products.LocationID == 1 && Products.ProductType == "Coffee")
                .ToList()
                .ForEach(Products => Console.WriteLine
                (
                    $"{Products.ProductName} {Products.ProductType} $ {Products.ProductPrice}"
                ));
            Console.Out.WriteLine("------------------------------");
        }
    }
}
