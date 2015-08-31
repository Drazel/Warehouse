using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;
using Warehouse.Data.Result;
using Warehouse.ServiceClient.WarehouseService;

namespace Warehouse.ServiceClient.Clients
{
    public static class PackageService
    {
        public static BoolResult AddPackage(Package package)
        {
            return ServiceManager.Call<PackageClient, BoolResult>(c => c.AddPackage(package));
        }

        public static BoolResult UpdateProduct(Package package)
        {
            return ServiceManager.Call<PackageClient, BoolResult>(c => c.UpdatePackage(package));
        }

        public static IEnumerable<Package> GetPackages()
        {
            return ServiceManager.Call<PackageClient, IEnumerable<Package>>(c => c.GetPackages());
        }

        public static Package GetPackage(string packageId)
        {
            return ServiceManager.Call<PackageClient, Package>(c => c.GetPackage(packageId));
        }
    }
}
