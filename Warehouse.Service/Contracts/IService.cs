using System;
using System.ServiceModel;

namespace Warehouse.Service.Contracts
{
    [ServiceContract]
    public interface IService
    {
        #region Methods

        [OperationContract]
        int Ping(DateTime date);

        #endregion
    }
}