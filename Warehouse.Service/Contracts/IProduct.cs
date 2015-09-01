using System.Collections.Generic;
using System.ServiceModel;
using Warehouse.Data.Dto;
using Warehouse.Data.Result;

namespace Warehouse.Service.Contracts
{
    [ServiceContract]
    public interface IProduct
    {
        #region Methods

        [OperationContract]
        BoolResult AddProduct(Product product);

        [OperationContract]
        BoolResult UpdateProduct(Product product);

        [OperationContract]
        IEnumerable<Product> GetProducts();

        [OperationContract]
        Product GetProduct(string productId);

        [OperationContract]
        Product GetProductByEan(string ean);

        #endregion
    }
}