using System.Collections.Generic;
using System.ServiceModel;
using Warehouse.Data.Dto;

namespace Warehouse.Service.Contracts
{
    [ServiceContract]
    public interface IProduct
    {
        #region Methods

        [OperationContract]
        bool AddProduct(Product product);

        [OperationContract]
        bool UpdateProduct(Product product);

        [OperationContract]
        IEnumerable<Product> GetProducts();

        [OperationContract]
        Product GetProduct(string productId);

        #endregion
    }
}