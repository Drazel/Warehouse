using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Dto;
using Warehouse.Data.Repository;
using Warehouse.Data.Result;
using Warehouse.Service.Contracts;

namespace Warehouse.Service
{
    public partial class Service : IProduct
    {
        private static ProductRepository productRepository = new ProductRepository();


        public BoolResult AddProduct(Data.Dto.Product product)
        {
            return productRepository.Add(product);
        }

        public BoolResult UpdateProduct(Data.Dto.Product product)
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

        public Product GetProductByEan(string ean)
        {
            return productRepository.GetProductByEan(ean);
        }
    }
}