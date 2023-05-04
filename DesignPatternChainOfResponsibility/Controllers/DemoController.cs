using Microsoft.AspNetCore.Mvc;

namespace DesignPatternChainOfResponsibility.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
