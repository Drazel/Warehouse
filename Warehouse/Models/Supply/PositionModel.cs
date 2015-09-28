using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models.Product;

namespace Warehouse.Models.Supply
{
    public class PositionModel
    {
        public int Lp { get; set; }
        public int Count { get; set; }
        public int AdoptedCount { get; set; }
        public ProductModel Product { get; set; }
    }
}