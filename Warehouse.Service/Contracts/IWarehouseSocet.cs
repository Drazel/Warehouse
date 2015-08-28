using System.Collections.Generic;
using System.ServiceModel;
using Warehouse.Data.Dto;

namespace Warehouse.Service.Contracts
{
    [ServiceContract]
    public interface IWarehouseSocet
    {
        #region Methods

        [OperationContract]
        bool AddWarehouseSocet(WarehouseSocet socet);

        [OperationContract]
        bool UpdateWarehouseSocet(WarehouseSocet socet);

        [OperationContract]
        IEnumerable<WarehouseSocet> GetWarehouseSocets();

        [OperationContract]
        WarehouseSocet GetWarehouseSocet(string socetId);

        #endregion
    }
}