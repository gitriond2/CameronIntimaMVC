using IndumentariaIntima.Data;
using IndumentariaIntima.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IndumentariaIntima.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var usuario = new Usuario
                {
                    NombreUsuario = model.NombreUsuario,
                    Contrasena = model.Contrasena // Nota: en una aplicación real, asegúrate de hashear las contraseñas
                };
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var usuario = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == model.NombreUsuario && u.Contrasena == model.Contrasena);
                if (usuario != null)
                {
                    // Lógica para manejar el inicio de sesión exitoso
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Nombre de usuario o contraseña incorrectos");
            }
            return View(model);
        }
    }
}


