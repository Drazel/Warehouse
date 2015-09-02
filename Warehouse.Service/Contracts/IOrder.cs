using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;
using Warehouse.Data.Result;

namespace Warehouse.Service.Contracts
{
    [ServiceContract]
    public interface IOrder
    {
        [OperationContract]
        BoolResult AddOrder(Order order);

        [OperationContract]
        IEnumerable<OutProductList> GetOutProductList();
    }
}
