using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Result
{
    public class ProductSum
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductEan { get; set; }
        public int ProductCount { get; set; }

        public ProductSum() { }

        public ProductSum(string id, string name, string ean, int count)
        {
            ProductId = id;
            ProductName = name;
            ProductEan = ean;
            ProductCount = count;
        }
    }
}
