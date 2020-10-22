using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Libraries;
using Models;


namespace BLL
{
    public class Inventory
    {

        public void GetInventories()
        {
            //Console.WriteLine("Our locations have...");
            Console.WriteLine("--------------");
            ProductToString();
            
        }
    }
}
