using Microsoft.AspNetCore.Mvc;

namespace LayoutProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // TODO: Implement authentication logic
            return RedirectToAction("Index", "Home");
        }
    }
}
