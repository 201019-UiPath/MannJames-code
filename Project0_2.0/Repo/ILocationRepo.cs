using System.Collections.Generic;
using Models;

namespace Repos
{
    public interface ILocationRepo
    {
        void AddLocation(Location location);
        List<Location> GetAllLocations();
        Location GetLocationById(int locationId);
    }
}
