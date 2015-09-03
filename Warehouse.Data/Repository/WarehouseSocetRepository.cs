using System;
using System.Security.Cryptography.X509Certificates;
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

        public WarehouseSocet GetSocetForProduct(Product product)
        {
            var builderFilter = Builders<WarehouseSocet>.Filter;
            var builderSort = Builders<WarehouseSocet>.Sort;
            var filter = builderFilter.Gte(x => x.FreeVolume, product.Volume) & builderFilter.Gte(x => x.FreeWeight, product.Weight)
                         & builderFilter.Gte(x => x.Height, product.Height) & builderFilter.Gte(x => x.Length, product.Length)
                         & builderFilter.Gte(x => x.Width, product.Width);
            var sort = builderSort.Descending(x => x.UseVolume).Descending(x => x.UseWeight);
            var result = GetByFiltrFirst(filter, sort);
            return result;
        }

        #endregion
    }
}