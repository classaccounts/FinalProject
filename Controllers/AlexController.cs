using FinalProjectWebServerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FinalProjectWebServerApp.Controllers
{
    public class AlexController : Controller
    {

        private AboutContext ctx;

        public AlexController(AboutContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult Hobby()
        {
            return View(getViewModel());
        }
        public IActionResult Project()
        {
            return View(getViewModel());
        }

        private AlexHobbyProjectViewModel getViewModel() {
            var ahpvm = new AlexHobbyProjectViewModel();
            ahpvm.Hobbies = ctx.Hobby.Where(s => s.StudentId == 2).ToList();
            ahpvm.Projects = ctx.Project.Where(s => s.StudentId == 2).ToList();
            return ahpvm;
        }
    }
}
