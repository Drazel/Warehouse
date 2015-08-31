using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warehouse.Models.WarehouseSocet
{
    public class SocetProductsModel
    {
        public Warehouse.Data.Dto.Product ProductId { get; set; }

        public string Ean { get; set; }

        public string SocetBarcode { get; set; }

        public Warehouse.Data.Dto.WarehouseSocet Socet { get; set; }

        public int ProductCount { get; set; }
    }
}