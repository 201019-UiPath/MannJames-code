using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace BLL
{
    //Locations should have records of order history
    class ViewLocations
    {
        public List<string> locations = new List<string>()
        {
            //import locations
            new Location(1, "testLoc", "A", "B", 6, "", "M-S: 10-18:00").ToString(),
            new Location(2, "testLoc", "d", "c", 11, "", "hours").ToString()
        };

        public void GetLocations()
        {
            foreach (string result in locations)
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
