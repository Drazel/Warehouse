using System.Collections.Generic;
using System.ServiceModel;
using Warehouse.Data.Dto;

namespace Warehouse.Service.Contracts
{
    [ServiceContract]
    public interface IPackage
    {
        #region Methods

        [OperationContract]
        bool AddPackage(Package product);

        [OperationContract]
        bool UpdatePackage(Package product);

        [OperationContract]
        IEnumerable<Package> GetPackages();

        [OperationContract]
        Package GetPackage(string productId);

        #endregion
    }
}