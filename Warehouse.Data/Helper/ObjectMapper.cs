using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;
using Warehouse.Data.Enum;
using Warehouse.Data.Repository;
using Warehouse.Data.Result;

namespace Warehouse.Data.Helper
{
    public static class ObjectMapper
    {
        public static Position Position(OrderPosition pos)
        {
            var repo = new ProductRepository();
            var result = new Position
                         {
                             Lp = pos.Lp,
                             Count = pos.Count,
                             Product = repo.GetById(pos.ProductId.Id.ToString())
                         };
            return result;
        }

        public static List<Position> Position(List<OrderPosition> pos)
        {
            var result = new List<Position>();
            pos.ForEach(x=> result.Add(Position(x)));
            return result;
        }
        
        public static Position Position(SupplyPosition pos)
        {
            var repo = new ProductRepository();
            var result = new Position
            {
                Lp = pos.Lp,
                Count = pos.Count,
                Product = repo.GetById(pos.ProductId.Id.ToString())
            };
            return result;
        }

        public static List<Position> Position(List<SupplyPosition> pos)
        {
            var result = new List<Position>();
            pos.ForEach(x => result.Add(Position(x)));
            return result;
        }

        public static SupplyItem Supply(Supply supply)
        {
            var result = new SupplyItem
                         {
                             Id = supply.SupplierId.ToString(),
                             City = supply.City,
                             CountryCode = supply.CountryCode,
                             CreateDate = supply.CreateDate,
                             FlatNumber = supply.FlatNumber,
                             HouseNumber = supply.HouseNumber,
                             Positions = ObjectMapper.Position(supply.Positions.ToList()),
                             PostalCode = supply.PostalCode,
                             Street = supply.Street,
                             SupplierId = supply.SupplierId,
                             SupplyNumber = supply.SupplyNumber,
                             SupplyStatus = supply.SupplyStatus
                         };
            return result;
        }
    }
}
