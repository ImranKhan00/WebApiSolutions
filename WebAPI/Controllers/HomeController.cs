using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        
        public ActionResult CreateIncident(cIncident model)
        {
            DataAccessLayer dl = new DataAccessLayer();
            dl.AddIncident(model);
            var SavedValue = dl.AddIncident(model);
            //if(SavedValue)
            //ViewBag.Message = "Record Added Successfully";
            //return Json(true);
            return Json(SavedValue);
        }
        
       //[HttpPost]
       // public ActionResult AddIncidentDetail(cIncident inc)
       // {
       //     try
       //     {
       //         if (ModelState.IsValid)
       //         {
       //             // WebApIController EmpRepo = new WebApIController();
       //             IncidentWebApp incRepo = new IncidentWebApp();

       //             if (EmpRepo.AddEmployee(inc))
       //             {
       //                 ViewBag.Message = "Employee details added successfully";
       //             }
       //         }

       //         return View();
       //     }
       //     catch
       //     {
       //         return View();
       //     }
       // }
    }
}
