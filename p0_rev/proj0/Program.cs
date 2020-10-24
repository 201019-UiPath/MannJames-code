using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Libraries;
using Models;

namespace Libraries
{
    //ToDo
    //correspond customer id with order id
    //input customer and get orders associated with it
    //list products on orders -> orderList
    //sql join analogue
    //var var = join(order,prod)
    //join(var,cust)
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/join-clause
    //https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to

    class Program
    {
        public static void Main(String[] args)
        {
            LocationLib lL = new LocationLib();
            Console.Out.WriteLine($"You chose Location {lL.loc1.LocationID} at");
            Console.Out.WriteLine($"{lL.loc1.Address} {lL.loc1.CityName} {lL.loc1.StateName} {lL.loc1.ZipCode}");
            Console.Out.WriteLine("------------------------------");
            ProductLib pL = new ProductLib();

            pL.ProductList.Where(Products => Products.LocationID == 1)
                .ToList()
                .ForEach(Products => Console.WriteLine
                (
                    $"{Products.ProductName} {Products.ProductType} $ {Products.ProductPrice}"
                ));
     
            //Console.Out.Write();
        }
    }
}
