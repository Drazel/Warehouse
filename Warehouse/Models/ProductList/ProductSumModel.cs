using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warehouse.Models.ProductList
{
    public class ProductSumModel
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductEan { get; set; }
        public int ProductCount { get; set; }
    }
}