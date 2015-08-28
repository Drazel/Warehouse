using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using Warehouse.Data.Dto;

namespace Warehouse.Data.Repository
{
    public class ProductRepository : ARespository<Product>
    {
        protected override string GetCollectionName()
        {
            return "Product";
        }

        public override bool Update(Product item)
        {
            throw new NotImplementedException();
        }

        public override bool Update(List<Product> item)
        {
            throw new NotImplementedException();
        }
    }
}
