using Microsoft.AspNetCore.Mvc;

namespace ContactMonthlyClaim02.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();

        }
    }
}
