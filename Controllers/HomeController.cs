using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using meteorGaming.Models;

namespace meteorGaming.Controllers
{
    public class HomeController : Controller

    {

        public IActionResult Index()

        {

            return View();

        }



        public JsonResult GetJsonData()

        {

            return Json(GetStock());

        }



        [NonAction]

        private List<Stockmodel> GetStock()

        {

            List<Stockmodel> model = new List<Stockmodel>();

            model.Add(new Stockmodel { stockId = 1, StockName = "Rel", StockPrice = 1200 });

            model.Add(new Stockmodel { stockId = 2, StockName = "Relaxo", StockPrice = 650 });

            model.Add(new Stockmodel { stockId = 3, StockName = "Tcs", StockPrice = 2100 });

            model.Add(new Stockmodel { stockId = 4, StockName = "IGL", StockPrice = 500 });

            model.Add(new Stockmodel { stockId = 5, StockName = "SBI", StockPrice = 200 });

            return model;

        }

    }
}
