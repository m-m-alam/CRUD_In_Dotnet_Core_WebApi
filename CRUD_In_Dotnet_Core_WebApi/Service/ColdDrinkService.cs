using CRUD_In_Dotnet_Core_WebApi.Data;
using CRUD_In_Dotnet_Core_WebApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_In_Dotnet_Core_WebApi.Service
{
    public class ColdDrinkService : IColdDrinkService
    {
        private readonly ApplicationDbContext _context;
        public ColdDrinkService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(tblColdDrinks entity)
        {
            if (entity != null)
            {
                _context.tblColdDrinks.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var data = _context.tblColdDrinks.Find(id);
            _context.tblColdDrinks.Remove(data);
            _context.SaveChanges();
        }
        public void DeleteByName(string name)
        {
            var data = _context.tblColdDrinks.FirstOrDefault(i=>i.strColdDrinksName == name);
            _context.tblColdDrinks.Remove(data);
            _context.SaveChanges();
        }

        public IEnumerable<tblColdDrinks> GetAll()
        {
            var data = _context.tblColdDrinks.ToList();
            return data;
        }

        public tblColdDrinks GetById(int id)
        {
            var data = _context.tblColdDrinks.Where(x => x.intColdDrinksId == id).FirstOrDefault();
            return data;
        }

        public void Update(tblColdDrinks entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteRange(IList<tblColdDrinks> entities)
        {
            _context.RemoveRange(entities);
        }

        
        public IEnumerable<string> GetAllNames()
        {
            return _context.tblColdDrinks.Select(i => i.strColdDrinksName);
        }

        public void DeleteByMinQuantity(int quantity)
        {
            var data = _context.tblColdDrinks.Where(x => x.numQuantity < quantity);
            _context.tblColdDrinks.RemoveRange(data);
            _context.SaveChanges();

        }

        public string GetTotalPrice()
        {
            var total = _context.tblColdDrinks.Sum(x => x.numUnitPrice*x.numQuantity);
            return total.ToString();
        }
    }
}
