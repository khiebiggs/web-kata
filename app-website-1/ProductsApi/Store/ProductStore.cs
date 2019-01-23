using System.Collections.Generic;
using ProductsApi.Model;

namespace ProductsApi.Store
{
    public class ProductStore
    {
        private List<Product> Products { get; set; }
        public ProductStore()
        {
            Products = new List<Product>();
        }
        public IEnumerable<Product> GetAll()
        {
            return Products;
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }
    }
}