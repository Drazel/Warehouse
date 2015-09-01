using System.Collections.Generic;
using System.ServiceModel;
using Warehouse.Data.Dto;
using Warehouse.Data.Result;

namespace Warehouse.Service.Contracts
{
    [ServiceContract]
    public interface IWarehouseSocet
    {
        #region Methods

        [OperationContract]
        BoolResult AddWarehouseSocet(WarehouseSocet socet);

        [OperationContract]
        BoolResult UpdateWarehouseSocet(WarehouseSocet socet);

        [OperationContract]
        IEnumerable<WarehouseSocet> GetWarehouseSocets();

        [OperationContract]
        WarehouseSocet GetWarehouseSocet(string socetId);

        [OperationContract]
        WarehouseSocet GetSocetByBarcode(string barcode);

        #endregion
    }
}