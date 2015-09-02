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
    }
}
