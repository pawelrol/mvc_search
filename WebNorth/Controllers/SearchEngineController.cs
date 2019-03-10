using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebNorth.Models;
using WebNorth.Repository;

namespace WebNorth.Controllers
{
    public class SearchEngineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string q)
        {
            SearchRepository search = new SearchRepository();

            Orders o = new Orders();
            o.OrderDate = Convert.ToDateTime(q);
            var result = search.SearchForOrders(o);


            return View(result);
        }


        [HttpGet]
        public IActionResult ShowOrders()
        {
            NORTHWNDContext db = new NORTHWNDContext();
            List<Orders> orders = db.Orders.ToList();
            var result = orders.OrderBy(x => x.ShipCity).ToList();
            return View(orders);
        }

        [HttpPost]
        public IActionResult ShowOrders(string sort)
        {
            if(sort == "asc")
            {
                NORTHWNDContext db = new NORTHWNDContext();
                List<Orders> orders = db.Orders.ToList();
                var result = orders.OrderBy(x => x.ShipCity).ToList();
                return View(result);
            } else
            {
                NORTHWNDContext db = new NORTHWNDContext();
                List<Orders> orders = db.Orders.ToList();
                var result = orders.OrderByDescending(x => x.ShipCity).ToList();
                return View(result);
            }
            
            
        }
    }
}