using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Result;
using Warehouse.ServiceClient.WarehouseService;
using Product = Warehouse.Data.Dto.Product;

namespace Warehouse.ServiceClient.Clients
{
    public static class ProductService
    {
        public static BoolResult AddProduct(Product product)
        {
            return ServiceManager.Call<ProductClient, BoolResult>(c => c.AddProduct(product));
        }

        public static BoolResult UpdateProduct(Product product)
        {
            return ServiceManager.Call<ProductClient, BoolResult>(c => c.UpdateProduct(product));
        }

        public static IEnumerable<Product> GetProducts()
        {
            return ServiceManager.Call<ProductClient, IEnumerable<Product>>(c => c.GetProducts());
        }

        public static Product GetProduct(string productId)
        {
            return ServiceManager.Call<ProductClient, Product>(c => c.GetProduct(productId));
        }

        public static Product GetProductByEan(string ean)
        {
            return ServiceManager.Call<ProductClient, Product>(c => c.GetProductByEan(ean));
        }
    }
}
