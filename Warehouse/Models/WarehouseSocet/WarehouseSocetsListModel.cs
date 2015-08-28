using System.Collections.Generic;

namespace Warehouse.Models.WarehouseSocet
{
    public class WarehouseSocetsListModel
    {
        #region Properties

        public List<WarehouseSocetModel> WarehouseSocets { get; set; }

        #endregion

        #region Constructors

        public WarehouseSocetsListModel()
        {
            WarehouseSocets = new List<WarehouseSocetModel>();
        }

        public WarehouseSocetsListModel(List<WarehouseSocetModel> warehouseSocets)
        {
            WarehouseSocets = warehouseSocets;
        }

        #endregion
    }
}