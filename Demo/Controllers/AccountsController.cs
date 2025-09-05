using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
