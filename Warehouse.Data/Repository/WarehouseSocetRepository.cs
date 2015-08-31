using MongoDB.Bson;
using MongoDB.Driver;
using Warehouse.Data.Dto;

namespace Warehouse.Data.Repository
{
    public class WarehouseSocetRepository : ARespository<WarehouseSocet>
    {
        #region Methods

        public string GetSocetByBarcode(string socetBarcode)
        {
            var filter = Builders<WarehouseSocet>.Filter.Eq("SocetBarcode", socetBarcode);
            var socet = GetByFiltrFirst(filter);
            return socet.ToJson();
        }

        #endregion
    }
}