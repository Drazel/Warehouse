using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Repository;
using Warehouse.Data.Result;
using Warehouse.Service.Contracts;

namespace Warehouse.Service
{
    public partial class Service : IPackage
    {
        private static PackageRepository packageRepository = new PackageRepository();

        public BoolResult AddPackage(Data.Dto.Package package)
        {
            return packageRepository.Add(package);
        }

        public BoolResult UpdatePackage(Data.Dto.Package package)
        {
            return packageRepository.Update(package);
        }

        public IEnumerable<Data.Dto.Package> GetPackages()
        {
            return packageRepository.GetItemsList();
        }

        public Data.Dto.Package GetPackage(string packageId)
        {
            return packageRepository.GetById(packageId);
        }
    }
}