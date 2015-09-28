using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Warehouse.Models.Supply;
using Warehouse.ServiceClient.Clients;

namespace Warehouse.Controllers
{
    public class SupplyController : Controller
    {
        // GET: Supply
        //public ActionResult GetSupply()
        //{
        //    var model = new GetSupplyModel();
        //    return View(model);
        //}

        public ActionResult GetSupply(string supplyNumber)
        {
            var model = new GetSupplyModel(supplyNumber);
            return View(model);
        }

        public ActionResult SupplyList()
        {
            var supplyItem = SupplyService.GetNewSupplys();
            var model = Mapper.Map<List<SupplyModel>>(supplyItem);
            return View(model);
        }

        public ActionResult SupplyArchyList()
        {
            var supplyItem = SupplyService.GetSupplys();
            var model = Mapper.Map<List<SupplyModel>>(supplyItem);
            return View(model);
        }

        public JsonResult GetSupplyAjax(string supplyNumber)
        {
            var model = new SupplyModel();
            try
            {
                var supply = SupplyService.GetSupplyBySupplyNumber(supplyNumber);
                model = Mapper.Map<SupplyModel>(supply);
                model.SetSucces();
            }
            catch (Exception ex)
            {
                model.SetError(ex);
            }

            return Json(model, JsonRequestBehavior.AllowGet);
        }
    
    }
}