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

        public string Show(string str, int n)
        {
            return "Stringul primit: " + str + "; nr. primit: " + n;
        }

    }
}
