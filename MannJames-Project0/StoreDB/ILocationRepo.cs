using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreDB
{
    public interface ILocationRepo
    {
        void AddLocation(Location location);
        Task<List<Location>> GetAllLocations();
        Location GetLocationById(int locId);
    }
}
