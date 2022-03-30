using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataAnnotations.Models;

namespace MVC_DataAnnotations.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}