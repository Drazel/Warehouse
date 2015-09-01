using MongoDB.Bson;
using MongoDB.Driver;
using Warehouse.Data.Dto;

namespace Warehouse.Data.Repository
{
    public class ProductRepository : ARespository<Product>
    {
        #region Methods

        public Product GetProductByEan(string ean)
        {
            var filter = Builders<Product>.Filter.Eq("Ean", ean);
            var product = GetByFiltrFirst(filter);
            return product;
        }

        #endregion
    }
}