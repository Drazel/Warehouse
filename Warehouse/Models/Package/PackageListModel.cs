        using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warehouse.Models.Package
{
    public class PackageListModel
    {
        public List<PackageModel> Packages { get; set; }

        public PackageListModel()
        {
           Packages=new List<PackageModel>();
        }

        public PackageListModel(List<PackageModel> packages)
        {
            Packages = packages;
        }
    }
}