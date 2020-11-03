using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDB
{
    public interface ILocationRepo
    {
        void AddLocation(Location location);
        List<Location> GetAllLocations();

        Location GetLocationById(int locId);
    }
}
