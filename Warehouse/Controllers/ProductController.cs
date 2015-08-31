using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Warehouse.Data.Dto;
using Warehouse.Models.Product;
using Warehouse.ServiceClient.Clients;

namespace Warehouse.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Add()
        {
            var model = new ProductModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var product = Mapper.Map<Product>(model);
                var result = ProductService.AddProduct(product);
                if (result.Succes)
                {
                    return RedirectToAction("List");
                }
            }

            return View(model);
        }

        public ActionResult List()
        {
            var products = ProductService.GetProducts();
            var model = new ProductsListModel(Mapper.Map<List<ProductModel>>(products));

            return View(model);
        }

        public ActionResult Update(string productId)
        {
            var product = ProductService.GetProduct(productId);
            var model = Mapper.Map<ProductModel>(product);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(ProductModel model)
        {
            return RedirectToAction("List");
        }
    }
}