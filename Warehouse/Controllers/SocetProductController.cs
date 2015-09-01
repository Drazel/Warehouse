using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.Ajax.Utilities;
using MongoDB.Bson;
using Warehouse.Models.Base;
using Warehouse.Models.Product;
using Warehouse.Models.WarehouseSocet;
using Warehouse.ServiceClient.Clients;
using WarehouseResource;

namespace Warehouse.Controllers
{
    public class SocetProductController : Controller
    {
        // GET: SocetProduct
        public ActionResult ProductToSocet()
        {
            return View();
        }

        public JsonResult GetProductByEanAjax(string ean)
        {
            var model = new ProductModel();
            try
            {
                var product = ProductService.GetProductByEan(ean);
                if (product != null)
                {
                    model = Mapper.Map<ProductModel>(product);
                    model.SetSucces();
                }
                else
                {
                    model.SetError(String.Format(ResProduct.NoProductForEan, ean));
                }
            }
            catch (Exception ex)
            {
                model.SetError(ex);
            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSocetByBarcodeAjax(string barcode)
        {
            var model = new WarehouseSocetModel();
            try
            {
                 var socet = WarehouseSocetService.GetSocetByBarcode(barcode);
                if (socet != null)
                {
                    model = Mapper.Map<WarehouseSocetModel>(socet);
                    model.SetSucces();
                }
                else
                {
                    model.SetError(String.Format(ResSocet.NoSocetToBarcode, barcode));
                }
            }
            catch (Exception ex)
            {
                model.SetError(ex);
            }
            
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SetProductToSocet(string productId, string socetId, int count)
        {
            var model = new BaseModel();

            if ((productId != string.Empty) && (socetId != string.Empty) && (count > 0))
            {
                var result = SocetProductsService.AddProductIdToSocetId(productId, socetId, count);
                model = Mapper.Map<BaseModel>(result);
            }
            else
            {
                model.SetError(ResError.DataEmpty);
            }

            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
    
}