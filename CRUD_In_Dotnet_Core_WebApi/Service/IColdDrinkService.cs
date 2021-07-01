using CRUD_In_Dotnet_Core_WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_In_Dotnet_Core_WebApi.Service
{
    public interface IColdDrinkService
    {
        IEnumerable<tblColdDrinks> GetAll();
        tblColdDrinks GetById(int id);
        void Add(tblColdDrinks entity);
        void Update(tblColdDrinks entity);
        void Delete(int id);
        void DeleteRange(IList<tblColdDrinks> entities);
        void DeleteByName(string name);
        IEnumerable<string> GetAllNames();
        void DeleteByMinQuantity(int quantity);
        string GetTotalPrice();
    }
}
