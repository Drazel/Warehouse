using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Warehouse.Data.Dto;
using Warehouse.Models.WarehouseSocet;
using Warehouse.ServiceClient.Clients;

namespace Warehouse.Controllers
{
    public class WarehouseSocetController : Controller
    {
        public ActionResult List()
        {
            var warehouseSocets = WarehouseSocetService.GetWarehouseSocets();
            var model = new WarehouseSocetsListModel(Mapper.Map<List<WarehouseSocetModel>>(warehouseSocets));
            return View(model);
        }

        // GET: WarehouseSocet/Create
        public ActionResult Create()
        {
            var model = new WarehouseSocetModel();
            return View(model);
        }

        // POST: WarehouseSocet/Create
        [HttpPost]
        public ActionResult Create(WarehouseSocetModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var socet = Mapper.Map<WarehouseSocet>(model);
                    var result = WarehouseSocetService.AddWarehouseSocet(socet);
                    
                    if (result)
                        return RedirectToAction("list");
                }
                catch
                {
                    return View(model);
                }
            }
            return View(model);
        }

        // GET: WarehouseSocet/Edit/5
        public ActionResult Edit(string socetId)
        {
            var socet = WarehouseSocetService.GetWarehouseSocet(socetId);
            var model = Mapper.Map<WarehouseSocetModel>(socet);
            return View(model);
        }

        // POST: WarehouseSocet/Edit/5
        [HttpPost]
        public ActionResult Edit(WarehouseSocetModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var socet = Mapper.Map<WarehouseSocet>(model);
                    var result = WarehouseSocetService.UpdateWarehouseSocet(socet);

                    if (result)
                        return RedirectToAction("list");
                }
                catch
                {
                    return View(model);
                }
            }
            return View(model);
        }
    }
}
