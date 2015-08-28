using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.ServiceClient.WarehouseService;
using Product = Warehouse.Data.Dto.Product;

namespace Warehouse.ServiceClient.Clients
{
    public static class ProductService
    {
        public static bool AddProduct(Product product)
        {
            return ServiceManager.Call<ProductClient, bool>(c => c.AddProduct(product));
        }

        public static bool UpdateProduct(Product product)
        {
            return ServiceManager.Call<ProductClient, bool>(c => c.UpdateProduct(product));
        }

        public static IEnumerable<Product> GetProducts()
        {
            return ServiceManager.Call<ProductClient, IEnumerable<Product>>(c => c.GetProducts());
        }

        public static Product GetProduct(string productId)
        {
            return ServiceManager.Call<ProductClient, Product>(c => c.GetProduct(productId));
        }
    }
}
