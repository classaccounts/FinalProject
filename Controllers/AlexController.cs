using Microsoft.AspNetCore.Mvc;

namespace FinalProjectWebServerApp.Controllers
{
    public class AlexController : Controller
    {
        public IActionResult Hobby()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
    }
}
