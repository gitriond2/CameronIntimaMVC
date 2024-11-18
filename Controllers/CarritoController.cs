using IndumentariaIntima.Models;
using IndumentariaIntima.Services;
using Microsoft.AspNetCore.Mvc;

namespace IndumentariaIntima.Controllers
{
    public class CarritoController : Controller
    {
        private readonly CarritoService _carritoService;
        private readonly IConfiguration _configuration;

        public CarritoController(CarritoService carritoService, IConfiguration configuration)
        {
            _carritoService = carritoService;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var items = _carritoService.GetItems();
            ViewData["StripePublishableKey"] = _configuration["Stripe:PublishableKey"];
            return View(items);
        }
        //public CarritoController(CarritoService carritoService)
        //{
        //    _carritoService = carritoService;
        //}

        //public IActionResult Index()
        //{
        //    var items = _carritoService.GetItems();
        //    return View(items);
        //}

        public IActionResult Add(int id)
        {
            _carritoService.AddItem(id);
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            _carritoService.RemoveItem(id);
            return RedirectToAction("Index");
        }
    }
}
