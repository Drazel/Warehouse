using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;
using Warehouse.Data.Enum;
using Warehouse.Data.Repository;

namespace OrderInput
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                CreateOrder();
            }
        }

        public static Order GetOrder(string id)
        {
            var orderRepository = new OrderRepository();

            return orderRepository.GetById(id);
        }

        public static void UpdateOrder(Order order)
        {

        }

        public static void CreateOrder()
        {
            var radOrder = new Random(DateTime.Now.Millisecond);
            var orderRepository = new OrderRepository();
            var order = new Order
            {
                City = "Sławno",
                OrderNumber = String.Format("{0}/{1}/{2}", radOrder.Next(10, 99), radOrder.Next(10, 99), radOrder.Next(1000, 9999)),
                RecipientId = radOrder.Next(1, 10),
                CountryCode = "PL",
                HouseNumber = "10",
                OrderStatus = eOrderStatus.New,
                PostalCode = "76-100",
                Realized = false,
                SendDate = DateTime.Now.AddDays(radOrder.Next(10)),
                Street = "Warszkowo",
                
            };
            order.Positions = CreateOrderPosition();
            orderRepository.Add(order);
        }

        public static List<OrderPosition> CreateOrderPosition()
        {
            var productRepository = new ProductRepository();
            var products = productRepository.GetItemsList().ToList();
            var radProduct = new Random(DateTime.Now.Millisecond);
            var productCount = radProduct.Next(1, 10);
            var result = new List<OrderPosition>();

            for (int i = 0; i <= productCount; i++)
            {
                var item = new OrderPosition();
                var j = radProduct.Next(products.Count());
                item.Lp = i + 1;
                item.SetProduct(products[j].Id);
                item.Count = radProduct.Next(1, 10);
                result.Add(item);
            }
            return result;
        }
    
    }
}
