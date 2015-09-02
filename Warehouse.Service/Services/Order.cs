using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Repository;
using Warehouse.Data.Result;
using Warehouse.Service.Contracts;

namespace Warehouse.Service
{
    public partial class Service : IOrder
    {
        private static OrderRepository orderRepository = new OrderRepository();

        public BoolResult AddOrder(Data.Dto.Order order)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<OutProductList> GetOutProductList()
        {
            return orderRepository.GetOutProductList();
        }
    }
}