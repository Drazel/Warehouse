using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Dto;
using Warehouse.Data.Repository;
using Warehouse.Service.Contracts;

namespace Warehouse.Service
{
    public partial class Service : IProduct
    {
        private static ProductRepository productRepository = new ProductRepository();


        public bool AddProduct(Data.Dto.Product product)
        {
            return productRepository.Add(product);
        }

        public bool UpdateProduct(Data.Dto.Product product)
        {
            return productRepository.Update(product);
        }

        public IEnumerable<Data.Dto.Product> GetProducts()
        {
            return productRepository.GetItemsList();
        }

        public Data.Dto.Product GetProduct(string productId)
        {
            return productRepository.GetById(productId);
        }
    }
}