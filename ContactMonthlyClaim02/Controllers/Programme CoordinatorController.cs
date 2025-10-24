using Microsoft.AspNetCore.Mvc;

namespace ContactMonthlyClaim02.Controllers
{
    public class CoordinatorController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
