using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SufferShopDB.Repos
{
    public interface IManagerRepo
    {
        /// <param name="manager"></param>
        void AddManager(Manager manager);
        Task<List<Manager>> GetAllManagersAsync();
        List<Manager> GetAllManagers();
        Task<Manager> GetManagerByMIdAsync(int managerId);
        Manager GetManagerByMId(int managerId);

    }
}
