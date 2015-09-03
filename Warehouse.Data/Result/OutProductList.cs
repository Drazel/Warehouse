using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;
using Warehouse.Data.Repository;

namespace Warehouse.Data.Result
{
    public class OutProductList
    {
        public DateTime Date { get; set; }
        public List<ProductSum> Products { get; set; }

        public OutProductList()
        {
            
        }

        public OutProductList(DateTime date)
        {
            Date = date.Date;
            Products = new List<ProductSum>();
        }

        public OutProductList(Order order)
        {
            Date = order.SendDate.Date;
            Products = new List<ProductSum>();
            AddProduct(order.Positions.ToList());
        }

        public void AddProduct(OrderPosition position)
        {
            var id = position.ProductId.Id.ToString();
            var item = Products.Find(x => x.ProductId == id);
            if (item == null)
            {
                var repo = new ProductRepository();
                var product = repo.GetById(id);
                var productSum = new ProductSum(position.ProductId.Id.ToString(), product.Name, product.Ean, position.Count);
                Products.Add(productSum);
            }
            else
            {
                item.ProductCount += position.Count;
            }
        }

        public void AddProduct(List<OrderPosition> positions)
        {
            foreach (var orderPosition in positions)
            {
                AddProduct(orderPosition);
            }
        }
    }
}
