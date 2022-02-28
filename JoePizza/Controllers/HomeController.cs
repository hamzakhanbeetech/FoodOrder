using JoePizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JoePizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public PizzaModel _context = new PizzaModel();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PizzaSelection()
        {

            return View(_context.getAllPizza());
        }


        public ActionResult OrderCheckout(int id)
        {
            return View(_context.getPizzaById(id));
        }

        // POST: CustomerSFController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OrderCheckout(int id, Pizza p)
        {
            try
            {
                int q = _context.getPizzaById(id).Quantity;

                p.Quantity = q - p.Quantity;
                if (p.Quantity > 0)
                    _context.order(p);
                return RedirectToAction("Confirmation", new { id = id });
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Confirmation(int id)
        {
            return View(_context.getPizzaById(id));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
