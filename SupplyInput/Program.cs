using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;
using Warehouse.Data.Enum;
using Warehouse.Data.Repository;
using Warehouse.ServiceClient.Clients;

namespace SupplyInput
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                CreateSupply();
            }
        }

        public static void CreateSupply()
        {
            var radOrder = new Random(DateTime.Now.Millisecond);
            var supply = new Supply
                         {
                             City = "Sławno",
                             SupplyNumber = String.Format("{0}/{1}/{2}", radOrder.Next(10, 99), radOrder.Next(10, 99), radOrder.Next(1000, 9999)),
                             SupplierId = radOrder.Next(1, 10),
                             CountryCode = "PL",
                             HouseNumber = "10",
                             SupplyStatus = eSupplyStatus.New,
                             PostalCode = "76-100",
                             CreateDate = DateTime.Now.AddDays(radOrder.Next(10)),
                             Street = "Warszkowo", 
                             Positions = CreateSupplyPosition(),

                         };
            var item = SupplyService.AddSupply(supply);
        }

        public static List<SupplyPosition> CreateSupplyPosition()
        {
            var productRepository = new ProductRepository();
            var products = productRepository.GetItemsList().ToList();
            var radProduct = new Random(DateTime.Now.Millisecond);
            var productCount = radProduct.Next(1, 10);
            var result = new List<SupplyPosition>();

            for (int i = 0; i <= productCount; i++)
            {
                var j = radProduct.Next(products.Count());
                var item = new SupplyPosition(i + 1, products[j].Id.ToString(), radProduct.Next(10, 100));
                result.Add(item);
            }
            return result;
        }
    }
}
