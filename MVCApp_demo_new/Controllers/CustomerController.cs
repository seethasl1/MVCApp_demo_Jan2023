using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp_demo_new.Models;

namespace MVCApp_demo_new.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
           

            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
       
        public ActionResult CustRegi()
        {
            List<SelectListItem> city = new List<SelectListItem>();
            city.Add(new SelectListItem { Text = "Chennai", Value = "1" });
            city.Add(new SelectListItem { Text = "Kolkata", Value = "2" });
            city.Add(new SelectListItem { Text = "Delhi", Value = "3" });

            ViewBag.Address = city;


            return View(new Customer());
          
        }
        [HttpPost]
        public ActionResult Submit(Customer cobj)
        {
            if(ModelState.IsValid)
            {
                var svalue = cobj.sname;
                ViewBag.slctedvalue = svalue.ToString();
               
                return View("DisplayRegi",cobj);
            }
            return RedirectToAction("CustRegi");
        }
        public ActionResult DisplayRegi()
        {
            Customer cobj = new Customer();
           
                return View(cobj);
        }
    }
}