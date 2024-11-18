using IndumentariaIntima.Models;
using IndumentariaIntima.Services;
using Microsoft.AspNetCore.Mvc;

namespace IndumentariaIntima.Controllers
{
    public class CarritoController : Controller
    {
        private readonly CarritoService _carritoService;

        public CarritoController(CarritoService carritoService)
        {
            _carritoService = carritoService;
        }

        public IActionResult Index()
        {
            var items = _carritoService.GetItems();
            return View(items);
        }

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

        [HttpPost]
        public IActionResult UpdateCantidad(int id, int cantidad)
        {
            _carritoService.UpdateItemCantidad(id, cantidad);
            return RedirectToAction("Index");
        }
    }
}
