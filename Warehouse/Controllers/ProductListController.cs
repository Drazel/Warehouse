using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Warehouse.Models.ProductList;
using Warehouse.ServiceClient.Clients;

namespace Warehouse.Controllers
{
    public class ProductListController : Controller
    {
        // GET: ProductList
        public ActionResult OutProductList()
        {
            var outProductList = OrderService.GetOutProductList();
            var model = Mapper.Map<List<OutProductListModel>>(outProductList);
            return View(model.OrderBy(x => x.Date).ToList());
        }

        public ActionResult WarehouseProduct()
        {
            return View();
        }
    }
}