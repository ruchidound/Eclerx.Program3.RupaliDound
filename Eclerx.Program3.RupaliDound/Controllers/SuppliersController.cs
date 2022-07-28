using Eclerx.Program3.RupaliDound.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eclerx.Program3.RupaliDound.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public SuppliersController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Suppliers
        public ActionResult Index()
        {
            var supplier = _dbContext.Suppliers.ToList();
            return View(supplier);
        }
        [HttpGet]
        public ActionResult InsertRecords()
        {
            var suppliers = _dbContext.Suppliers.ToList();
            ViewBag.Suppliers = suppliers;
            return View();
        }
        [HttpPost]
        public ActionResult InsertRecords(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Suppliers.Add(supplier);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            var suppliers = _dbContext.Suppliers.ToList();
            ViewBag.Suppliers = suppliers;
            return View();
        }

        public ActionResult Edit(int id)
        {
            var supplier = _dbContext.Suppliers.FirstOrDefault(s => s.SupplierId == id);
            //var suppliers = _dbContext.Suppliers.ToList();
            ViewBag.Suppliers = supplier;
            return View(supplier);
        }

        [HttpPost]
        public ActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                var supplierfromdb = _dbContext.Suppliers.FirstOrDefault(s => s.SupplierId == supplier.SupplierId);
                supplierfromdb.ContactName = supplier.ContactName;
                supplierfromdb.Address = supplier.Address;
                supplierfromdb.City = supplier.City;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            var suppliers = _dbContext.Suppliers.ToList();
            ViewBag.Suppliers = suppliers;
            return View(supplier);
        }
    }
}