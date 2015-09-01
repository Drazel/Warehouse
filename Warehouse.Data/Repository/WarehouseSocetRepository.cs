using System;
using MongoDB.Bson;
using MongoDB.Driver;
using Warehouse.Data.Dto;
using Warehouse.Data.Result;

namespace Warehouse.Data.Repository
{
    public class WarehouseSocetRepository : ARespository<WarehouseSocet>
    {
        #region Methods

        public WarehouseSocet GetSocetByBarcode(string socetBarcode)
        {
            var filter = Builders<WarehouseSocet>.Filter.Eq("SocetBarcode", socetBarcode);
            var socet = GetByFiltrFirst(filter);
            return socet;
        }

        public BoolResult UpdateUseVolumeAndWeight(ObjectId socetId, double weight, int volume)
        {
            var result = new BoolResult();
            try
            {
                var socet = GetById(socetId);
                socet.UseVolume += volume;
                socet.UseWeight += weight;
                Update(socet);
                result.SetSucces();
            }
            catch (Exception ex)
            {
                result.SetError(ex);
            }

            return result;
        }

        public BoolResult UpdateUseVolumeAndWeight(string socetId, double weight, int volume)
        {
            var result = new BoolResult();
            try
            {
                var socet = GetById(socetId);
                socet.UseVolume += volume;
                socet.UseWeight += weight;
                Update(socet);
                result.SetSucces();
            }
            catch (Exception ex)
            {
                result.SetError(ex);
            }

            return result;
        }

        #endregion
    }
}