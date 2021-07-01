using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_In_Dotnet_Core_WebApi.Model
{
    public class tblColdDrinks
    {
        public int intColdDrinksId { get; set; }
        public string strColdDrinksName { get; set; }
        public double numQuantity { get; set; }
        public double numUnitPrice { get; set; }
        
    }
}
