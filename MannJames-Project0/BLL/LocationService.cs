using Models;
using StoreDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public class LocationService
    {
        private ILocationRepo locationRepo;
        public LocationService(ILocationRepo locationRepo)
        {
            this.locationRepo = locationRepo;
        }
        public void AddLocation(Location location)
        {
            locationRepo.AddLocation(location);
        }
        public List<Location> GetAllLocations()
        {
            Task<List<Location>> getProductsTask =
                locationRepo.GetAllLocations();
            return getProductsTask.Result;
        }
/*        public Location GetLocationById(int locId)
        {
            Location resultLocation = locationRepo.GetLocationById(locId);
            return resultLocation;
        }*/
    }
}
