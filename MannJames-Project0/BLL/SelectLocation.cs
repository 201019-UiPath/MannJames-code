using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Security.Cryptography.X509Certificates;

namespace BLL
{
    public class SelectLocation
    {
        public static string locIdInput = Console.ReadLine().ToString();
        public int locId = Int32.Parse(locIdInput);

        //fix ilist from there once all of bll is in place
        public void LocationFilter(int locId) {
            //https://www.tutorialsteacher.com/linq/linq-method-syntax

            //collect locations from source
            //not viewlocations
            IList<Location> locations = new List<Location>()
            {
                new Location(1, "testLoc", "A", "B", 6, "", "M-S: 10-18:00"),
                new Location(2, "testLoc", "d", "c", 11, "", "hours")
            };

            var resultLocation = locations.Where(l => l.LocationId == locId).ToList<Location>();
            
            foreach(Location result in resultLocation)
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
