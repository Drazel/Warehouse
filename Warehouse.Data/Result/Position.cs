using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;

namespace Warehouse.Data.Result
{
    public class Position
    {
        public int Lp { get; set; }
        public int Count { get; set; }
        public int AdoptedCount { get; set; }
        public Product Product { get; set; }
    }
}
