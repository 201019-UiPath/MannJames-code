using System.Collections.Generic;
using Models;
using Repos;

namespace Services
{
    public class LocationService
    {
        private ILocationRepo repo;

        public LocationService(ILocationRepo repo)
        {
            this.repo = repo;
        }
        public void AddLocation(Location location)
        {
            repo.AddLocation(location);
        }
        public List<Location> GetAllLocations()
        {
            return repo.GetAllLocations();
        }
        public Location GetLocationById(int locationId)
        {
            return repo.GetLocationById(locationId);
        }
    }
}
