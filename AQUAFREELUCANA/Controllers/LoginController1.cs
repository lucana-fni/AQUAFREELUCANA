using AQUAFREELUCANA.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AQUAFREELUCANA.Controllers
{
    public class LoginController : Controller
    {
        private MiContext _context;
        public LoginController(MiContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string cuenta, string password)
        {

            var usuario = await _context.Usuarios
                                    .Where(x => x.Cuenta == cuenta && x.Password == password)
                                    .FirstOrDefaultAsync();
            if (usuario != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["LoginError"] = "Cuenta o password INCORRECTO";
                return RedirectToAction("Index");
            }

        }
    }
}
