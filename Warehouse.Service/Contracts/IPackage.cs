using System.Collections.Generic;
using System.ServiceModel;
using Warehouse.Data.Dto;
using Warehouse.Data.Result;

namespace Warehouse.Service.Contracts
{
    [ServiceContract]
    public interface IPackage
    {
        #region Methods

        [OperationContract]
        BoolResult AddPackage(Package product);

        [OperationContract]
        BoolResult UpdatePackage(Package product);

        [OperationContract]
        IEnumerable<Package> GetPackages();

        [OperationContract]
        Package GetPackage(string productId);

        #endregion
    }
}