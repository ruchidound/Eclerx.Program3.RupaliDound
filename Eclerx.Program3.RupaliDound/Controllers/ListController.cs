using Eclerx.Program3.RupaliDound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eclerx.Program3.RupaliDound.Controllers
{
    public class ListController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;
        public ListController()
        {
            _dbContext = new ApplicationDbContext();
        }
        private IEnumerable<SelectListItem> PopulateSupplier()
        {
            return _dbContext.Suppliers.Select(c => new SelectListItem
            {
                Value = c.City,
                Text = c.City
            }).AsEnumerable();
        }
        // GET: List
        public ActionResult List()
        {
            var suppliers = _dbContext.Suppliers.ToList();
            ViewBag.Suppliers = suppliers;
            return View();
        }
        //public ActionResult GetCities(string CityName)
        //{
        //    Supplier sp = new Supplier();
        //    var products = _dbContext.Suppliers.Include(p => p.City).Where(c => c.CityName == CityName);
        //    sp.Suppliers = products;

        //    var categories = PopulateSupplier();
        //    sp.suppliers = categories;
        //    return View("Index", sp);
        //}
    }
}