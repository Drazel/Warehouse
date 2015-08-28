using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;

namespace Warehouse.Data.Repository
{
    public class PackageRepository : ARespository<Package>
    {
        protected override string GetCollectionName()
        {
            return "Package";
        }

        public override bool Update(Package item)
        {
            throw new NotImplementedException();
        }

        public override bool Update(List<Package> item)
        {
            throw new NotImplementedException();
        }
    }
}
