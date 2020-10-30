using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Libraries;
using System.Security.Cryptography.X509Certificates;

namespace BLL
{
    public class LocationList
    { 
        //Console.Write("Input a location: ");
        //public int locId = 0;
        public static string locIdInput = Console.ReadLine().ToString();
        public int locId = Int32.Parse(locIdInput);

        public void Locations(int locId) {
            //https://www.tutorialsteacher.com/linq/linq-method-syntax


        IList<Location> locations = new List<Location>()
        {
            new Location(1, "testLoc", "A", "B", 6, "M-S: 10-18:00"),
            new Location(2, "testLoc", "d", "c", 11, "hours")
        };

            var resultLocation = locations.Where(l => l.LocationId == 1).ToList<Location>();
                }



    }
}
