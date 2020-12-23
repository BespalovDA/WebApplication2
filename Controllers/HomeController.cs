using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult About(int num1, int num2, string operation)
        {
            int numData;
            string returnData = "";
            if (operation == "+")
            {
                numData = num1 + num2;
                returnData = $"Result: {num1} + {num2} = {numData}";
            }
            else if (operation == "-")
            {
                numData = num1 - num2;
                returnData = $"Result: {num1} - {num2} = {numData}";
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    numData = num1 / num2;
                }
                else numData = -1;
                returnData = $"Result: {num1} / {num2} = {numData}";
            }
            else if (operation == "*")
            {
                numData = num1 * num2;
                returnData = $"Result: {num1} * {num2} = {numData}";
            }
            return Content(returnData);
        }

        public IActionResult Contact()
        {
            ViewData["RNG"] = new RNG();
            return View();
        }

        public IActionResult VB()
        {
            ViewBag.rng = new RNG();
            return View();
        }

        public IActionResult direct()
        {
            var rng = new RNG();
            return View(rng);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
