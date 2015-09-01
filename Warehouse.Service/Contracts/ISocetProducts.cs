using System.ServiceModel;
using Warehouse.Data.Dto;
using Warehouse.Data.Result;

namespace Warehouse.Service.Contracts
{
    [ServiceContract]
    public interface ISocetProducts
    {
        #region Methods

        [OperationContract]
        BoolResult AddProductToSocet(Product product, WarehouseSocet socet);

        [OperationContract]
        BoolResult AddProductIdToSocetId(string productId, string socetId);

        [OperationContract]
        BoolResult AddManyProductToSocet(Product product, WarehouseSocet socet, int count);

        [OperationContract]
        BoolResult AddManyProductIdToSocetId(string productId, string socetId, int count);

        [OperationContract]
        BoolResult GetProductFromSocet(Product product, WarehouseSocet socet);

        [OperationContract]
        BoolResult GetManyProductFromSocet(Product product, WarehouseSocet socet, int count);

        #endregion
    }
}