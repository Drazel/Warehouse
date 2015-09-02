using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Warehouse.Data.Dto;
using Warehouse.Data.Enum;
using Warehouse.Data.Result;

namespace Warehouse.Data.Repository
{
    public class OrderRepository : ARespository<Order>
    {
        protected override UpdateDefinition<Order> GetUpdateDefinition(Order item)
        {
            var update = Builders<Order>.Update;

            var result = update.Set(x => x.Positions, item.Positions);
            result = result.Set(x => x.Realized, item.Realized);
            result = result.Set(x => x.OrderStatus, item.OrderStatus);
            return result;
        }

        protected UpdateDefinition<Order> GetUpdateStatusDefinition(eOrderStatus staus)
        {
            var update = Builders<Order>.Update;

            return update.Set(x => x.OrderStatus, staus);
        }

        public BoolResult ChangeOrderStatus(string orderId, eOrderStatus staus)
        {
            return Update(orderId, GetUpdateStatusDefinition(staus));
        }

        public List<OutProductList> GetOutProductList()
        {
            var filter = Builders<Order>.Filter.Eq(x => x.OrderStatus, eOrderStatus.New);
            var orders = GetByFiltr(filter);
            var result = new List<OutProductList>();

            foreach (var order in orders)
            {
                var item = result.FirstOrDefault(x => x.Date == order.SendDate.Date);
                if (item == null)
                {
                    var outProductList = new OutProductList(order);
                    result.Add(outProductList);
                }
                else
                {
                    item.AddProduct(order.Positions.ToList());
                }
            }

            return result;
        }
    }
}
