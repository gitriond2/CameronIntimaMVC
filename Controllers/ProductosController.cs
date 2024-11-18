using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IndumentariaIntima.Data;

namespace IndumentariaIntima.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Productos.ToListAsync());
        }
    }
}
