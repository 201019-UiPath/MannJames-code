using project0;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace project0
{
    class Inventory
    {


        //static void Main(string[] args)
        //{
        public static void GetInventory()
        {
            Console.WriteLine("Our locations have...");
            Console.WriteLine("--------------");
            Location loc1 = new Location
                (
                    //ILocation.locationID = 1,
                    1,
                    "11001 Sample Road",
                    "Coral Springs",
                    "FL",
                    "33065"
                );

                Product prod1_1 = new Product
                (
                    1,
                    "Truffle Olive Oil",
                    "Oils",
                    "32.50"
                );
                Product prod1_2 = new Product
                (
                    1,
                    "Truffle Olive Oil",
                    "Oils",
                    "32.50"
                );
                Product prod1_3 = new Product
                (
                    1,
                    "Truffle Olive Oil",
                    "Oils",
                    "32.50"
                );
                Product prod1_4 = new Product
                (
                    2,
                    "EV Olive Oil",
                    "Oils",
                    "9.50"
                );
                Product prod1_5 = new Product
                (
                    1,
                    "Truffle Olive Oil",
                    "Oils",
                    "32.50"
                );
            Console.WriteLine("--------------");
            Location loc2 = new Location(
                    2,
                    "3200 College Ave",
                    "Davie",
                    "FL",
                    "33321"
                );
                Product prod2_1 = new Product
                (
                    2,
                    "EV Olive Oil",
                    "Oils",
                    "9.50"
                );
                Product prod2_2 = new Product
                (
                    2,
                    "EV Olive Oil",
                    "Oils",
                    "9.50"
                );
                Product prod2_3 = new Product
                (
                    2,
                    "EV Olive Oil",
                    "Oils",
                    "9.50"
                );
            Console.WriteLine("--------------");
            Location loc3 = new Location(
                    3,
                    "19221 Powerline Road",
                    "Pompano Beach",
                    "FL",
                    "33076"
                );

                Product prod3_1 = new Product
                (
                    2,
                    "EV Olive Oil",
                    "Oils",
                    "9.50"
                );
                Product prod3_2 = new Product
                (
                    2,
                    "EV Olive Oil",
                    "Oils",
                    "9.50"
                );
                Product prod3_3 = new Product
                (
                    2,
                    "EV Olive Oil",
                    "Oils",
                    "9.50"
                );
                Product prod3_4 = new Product
                (
                    2,
                    "EV Olive Oil",
                    "Oils",
                    "9.50"
                );


/*                Console.WriteLine($"{loc1.address} {loc1.cityName} " +
                    $"{loc1.stateName} {loc1.zipCode}");
                Console.WriteLine($"{prod1_1.productName} {prod1_1.productType} " +
                    $"{prod1_1.productPrice}");
                Console.WriteLine($"{prod1_2.productName} {prod1_2.productType} " +
                    $"{prod1_2.productPrice}");
                Console.WriteLine($"{prod1_3.productName} {prod1_3.productType} " +
                    $"{prod1_3.productPrice}");
                Console.WriteLine($"{prod1_4.productName} {prod1_4.productType} " +
                    $"{prod1_4.productPrice}");
                Console.WriteLine($"{prod1_5.productName} {prod1_5.productType} " +
                    $"{prod1_5.productPrice}");*/

                Console.WriteLine("--------------");
                /*
                                Console.WriteLine($"{loc2.address} {loc2.cityName} " +
                                    $"{loc2.stateName} {loc2.zipCode}");
                                Console.WriteLine($"{prod2_1.productName} {prod2_1.productType} " +
                                    $"{prod2_1.productPrice}");
                                Console.WriteLine($"{prod2_2.productName} {prod2_2.productType} " +
                                    $"{prod2_2.productPrice}");
                                Console.WriteLine($"{prod2_3.productName} {prod2_3.productType} " +
                                    $"{prod2_3.productPrice}");

                                Console.WriteLine("--------------");

                                Console.WriteLine($"{loc3.address} {loc3.cityName} " +
                                    $"{loc3.stateName} {loc3.zipCode}");
                                Console.WriteLine($"{prod3_1.productName} {prod3_1.productType} " +
                                    $"{prod3_1.productPrice}");
                                Console.WriteLine($"{prod3_2.productName} {prod3_2.productType} " +
                                    $"{prod3_2.productPrice}");
                                Console.WriteLine($"{prod3_3.productName} {prod3_3.productType} " +
                                    $"{prod3_3.productPrice}");
                                Console.WriteLine($"{prod3_4.productName} {prod3_4.productType} " +
                                    $"{prod3_4.productPrice}");
                */
           // }
        }
    }
}
