using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;

namespace Warehouse.Data.Repository
{
    public class WarehouseSocetRepository : ARespository<WarehouseSocet>
    {
        protected override string GetCollectionName()
        {
            return "WarehouseSocet";
        }

        public override bool Update(WarehouseSocet item)
        {
            throw new NotImplementedException();
        }

        public override bool Update(List<WarehouseSocet> item)
        {
            throw new NotImplementedException();
        }
    }
}
