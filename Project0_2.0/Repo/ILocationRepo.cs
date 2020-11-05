using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repos
{
    public interface ILocationRepo
    {
        List<Location> GetAllLocations();
        Task<List<Location>> GetAllLocationsAsync();
        List<InventoryProduct> GetAllInventoryProductsAtLocation(int locationId);

        Task<List<InventoryProduct>> GetAllInventoryProductssAtLocationAsync(int locationId);

        void AddInventoryLineItem(InventoryProduct lineItem);

        void UpdateInventoryLineItem(InventoryProduct lineItem);

        void RemoveInventoryLineItem(InventoryProduct lineItem);



    }
}