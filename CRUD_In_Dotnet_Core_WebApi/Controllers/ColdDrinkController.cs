using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_In_Dotnet_Core_WebApi.Model;
using CRUD_In_Dotnet_Core_WebApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_In_Dotnet_Core_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColdDrinkController : ControllerBase
    {
        private readonly IColdDrinkService _service;
        public ColdDrinkController(IColdDrinkService service)
        {
            _service = service;
        }
        //API 01

        [HttpPost]
        [Route("[action]")]
        [Route("api/ColdDrink/AddProduct")]
        public void AddProduct(tblColdDrinks product)
        {
            _service.Add(product);
        }

        //API 02
        [HttpPut]
        [Route("[action]")]
        [Route("api/ColdDrink/UpdateProduct")]
        public void UpdateProduct(tblColdDrinks product)
        {
            _service.Update(product);
        }

        //API 03

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ColdDrink/DeleteProductRange")]
        public void DeleteProductRange(IList<tblColdDrinks> product)
        {
            _service.DeleteRange(product);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ColdDrink/DeleteProduct")]
        public void DeleteProduct(int id)
        {
            _service.Delete(id);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ColdDrink/DeleteProductByName")]
        public void DeleteProductByName(string productName)
        {
            _service.DeleteByName(productName);
        }
        //API 04
        [HttpGet]
        [Route("[action]")]
        [Route("api/ColdDrink/GetAllProductNames")]
        public IEnumerable<string> GetAllProductNames()
        {
            return _service.GetAllNames();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ColdDrink/GetAllProduct")]
        public IEnumerable<tblColdDrinks> GetAllProduct()
        {
            return _service.GetAll();
        }
       
        
        //API 05
        [HttpDelete]
        [Route("[action]")]
        [Route("api/ColdDrink/DeleteByMinQuantity")]
        public void DeleteByMinQuantity(int quantity)
        {
            
            _service.DeleteByMinQuantity(quantity);
        }

        //API 06
        [HttpGet]
        [Route("[action]")]
        [Route("api/ColdDrink/TotalPrice")]
        public string TotalPrice()
        {

            var data = _service.GetTotalPrice();
            return data;
        }


    }
}
