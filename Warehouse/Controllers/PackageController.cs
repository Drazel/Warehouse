using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Warehouse.Data.Dto;
using Warehouse.Models.Package;
using Warehouse.ServiceClient.Clients;

namespace Warehouse.Controllers
{
    public class PackageController : Controller
    {
        // GET: Package/Create
        public ActionResult Create()
        {
            var model = new PackageModel();

            return View(model);
        }

        // POST: Package/Create
        [HttpPost]
        public ActionResult Create(PackageModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var package = Mapper.Map<Package>(model);
                    var result = PackageService.AddPackage(package);

                    if(result)
                        return RedirectToAction("List");
                }
            }
            catch
            {
                return View(model);
            }
            return View(model);
        }

        // GET: Package/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new PackageModel();
            return View(model);
        }

        // POST: Package/Edit/5
        [HttpPost]
        public ActionResult Edit(string packageId)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Package/Delete/5
        public ActionResult List()
        {
            var packeges = PackageService.GetPackages();
            var model = new PackageListModel(Mapper.Map<List<PackageModel>>(packeges));

            return View(model);
        }
    }
}
