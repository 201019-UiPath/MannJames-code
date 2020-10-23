using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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

            void ProdToString(Product prod)
            {
                Console.Out.WriteLine($"{prod.ProductName}");
                Console.Out.WriteLine($"{prod.ProductType}");
                Console.Out.WriteLine($"{prod.ProductPrice}");
            }
            ProductLib pL;

            void LocToString(Location loc)
            {
                Console.Out.WriteLine($"{loc.Address}");
                Console.Out.WriteLine($"{loc.CityName}");
                Console.Out.WriteLine($"{loc.StateName}");
                Console.Out.WriteLine($"{loc.ZipCode}");
            }
            LocationLib lL;

            void OrdToString(Order ord) 
            {
                Console.Out.WriteLine($"{ord.OrderDate}");
            }
            OrderLib oL;

            void CustToString(Customer cust)
            {
                Console.Out.WriteLine($"{cust.FirstName}");
                Console.Out.WriteLine($"{cust.LastName}");
                Console.Out.WriteLine($"{cust.PhoneNumber}");
            }
            CustomerLib cL = new CustomerLib();
            CustToString(cL.cust1);
            /*
            void Inventory()
            {

                //location 1
                Console.Out.WriteLine("-----------------");
                LocToString(lL.loc1);
                Console.Out.WriteLine("-----------------");
                ProdToString(pL.prod1);
                ProdToString(pL.prod1);
                ProdToString(pL.prod1);
                ProdToString(pL.prod2);
                ProdToString(pL.prod2);
                Console.Out.WriteLine("-----------------");
                
                Console.Out.WriteLine("-----------------");
                LocToString(lL.loc2);
                Console.Out.WriteLine("-----------------");
                //location2
                ProdToString(pL.prod1);
                ProdToString(pL.prod2);
                ProdToString(pL.prod2);
                ProdToString(pL.prod2);
                Console.Out.WriteLine("-----------------");
                Console.Out.WriteLine("-----------------");
                LocToString(lL.loc3);
                Console.Out.WriteLine("-----------------");
                //location3
                ProdToString(pL.prod1);
                ProdToString(pL.prod1);
                ProdToString(pL.prod1);
                ProdToString(pL.prod1);
                Console.Out.WriteLine("-----------------");
            }
            */

 


            //create orders
            //test email for orders once made?

            //Inventory();


        }
    }
}
