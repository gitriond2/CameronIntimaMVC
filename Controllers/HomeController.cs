using Microsoft.AspNetCore.Mvc;
using IndumentariaIntima.Data;
using IndumentariaIntima.Services;
using System.Linq;

namespace IndumentariaIntima.Controllers
{
    [ResponseCache(Duration = 60)] // Cachear la respuesta durante 60 segundos
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly CarritoService _carritoService;

        public HomeController(ApplicationDbContext context, CarritoService carritoService)
        {
            _context = context;
            _carritoService = carritoService;
        }

        public IActionResult Index()
        {
            var productos = _context.Productos.ToList();
            ViewBag.CarritoResumen = _carritoService.GetCarritoResumen();
            return View(productos);
        }
    }
}










//si estas mostrando productos en la pagina principal
//using Microsoft.AspNetCore.Mvc;
//using IndumentariaIntima.Data;

//namespace IndumentariaIntima.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public HomeController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index()
//        {
//            var productos = _context.Productos.ToList();
//            return View(productos);
//        }
//    }
//}















//public class HomeController : Controller
//{
//    private readonly ILogger<HomeController> _logger;

//    public HomeController(ILogger<HomeController> logger)
//    {
//        _logger = logger;
//    }

//    public IActionResult Index()
//    {
//        return View();
//    }

//    public IActionResult Privacy()
//    {
//        return View();
//    }

//    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//    public IActionResult Error()
//    {
//        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//    }
//}
