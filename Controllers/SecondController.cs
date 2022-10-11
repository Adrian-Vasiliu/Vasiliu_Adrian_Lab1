using Microsoft.AspNetCore.Mvc;

namespace Vasiliu_Adrian_Lab1.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Show(string str, int n)
        {
            return View();
        }

    }
}
