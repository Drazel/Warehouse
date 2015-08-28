using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;
using Warehouse.Data.Repository;

namespace WarehouseInput
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateProduct();
            InsertProductList(list);
        }

        private static List<Product> CreateProduct()
        {
            var list = new List<Product>();
            var product = new Product
                         {
                             Name = "Produkt test 2",
                             Ean = "11987654321",
                             Height = 45,
                             Length = 20,
                             Weight = 1,
                             Width = 30
                         };
            list.Add(product);
            return list;
        }

        private static void InsertProductList(List<Product> list)
        {
            var repo = new ProductRepository();

            foreach (var item in list)
            {
                repo.Add(item);
            }
        }
    }
}
