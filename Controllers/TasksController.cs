using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ViewTask.Controllers
{
    public class TasksController : Controller
    {
        private static readonly List<string> Supermarkets = new() { "WellMart", "Silpo", "ATB", "Furshet", "Metro" };

        private static readonly Dictionary<string, int> ShoppingItems = new()
        {
            { "Milk", 2 },
            { "Bread", 2 },
            { "Cake", 1 },
            { "Ice Cream", 5 },
            { "Cola", 10 }
        };

        public IActionResult SprintTasks()
        {
            return View();
        }

        public IActionResult Greetings()
        {
            return View();
        }

        public IActionResult ProductInfo()
        {
            return View();
        }

        public IActionResult SuperMarkets()
        {
            ViewBag.Supermarkets = Supermarkets;
            return View();
        }

        public IActionResult ShoppingList()
        {
            return View(ShoppingItems);
        }

        [HttpGet]
        public IActionResult ShoppingCart()
        {
            ViewBag.Supermarkets = Supermarkets;
            return View(ShoppingItems);
        }

        [HttpPost]
        public IActionResult ShoppingCart(string name, string address, string supermarket, string shippingDate, string[] products)
        {
            ViewBag.Message = $"Your products will be shipped to {address} from {supermarket} on {shippingDate}. Bon appetite, {name}!";
            return View("ShoppingCartResult");
        }
    }
}
