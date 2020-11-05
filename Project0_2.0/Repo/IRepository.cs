using System;
using System.Collections.Generic;
using System.Text;
using Models;
using SufferShopDB.Repos;

namespace Repos
{
    public interface IRepository : 
        ICustomerRepo, IEmployeeRepo, ILocationRepo, IOrderRepo, IProductRepo, 
        IManagerRepo
    {
        void SaveChangesAsync();
        void SaveChanges();
    }
}
