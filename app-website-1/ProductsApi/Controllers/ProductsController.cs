using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Model;
using ProductsApi.Store;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]/{name}")]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private ProductStore Store;

        public ProductsController(ProductStore store)
        {
            Store = store;
        }

        [HttpGet]
        public IEnumerable<Product> Get(string name)
        {
            if (name == null)
            {
                return Store.GetAll();
            }
            return Store.GetAll().Where(p => p.Name == name);
        }

        [HttpPost]
        public void Post([FromBody] Product value)
        {
            Store.Add(value);
        }
    }
}