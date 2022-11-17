using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(InputViewModel model)
        {


            if (ModelState.IsValid)
            {

                return View("Index", model);

            }
            else
            {
                return View("Error");
            }

            //var manoObjektas = new ManoTest();
            //manoObjektas.Query = kint;
            //manoObjektas.Skaicius = skaicius;





            //ViewBag.manoStringas = mystring; //ideda i view,vengti naudot
            //ViewData["foo"] = mystring; //ideda i view,vengti naudot
            //TempData["bar"] = mystring; //ideda i view,vengti naudot



            //return View("Index", manoObjektas);
            //return View("Index", model);
        }

        public IActionResult Verslas(string q, int sk)
        {
            return View();
        }


    }
}
