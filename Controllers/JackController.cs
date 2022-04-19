using Microsoft.AspNetCore.Mvc;
using FinalProjectWebServerApp.Models;
using System.Linq;

namespace FinalProjectWebServerApp.Controllers
{
    public class JackController : Controller
    {
        private AboutContext ctx;

        public JackController(AboutContext ctx)
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

        private JackHobbyProjectViewModel getViewModel() {
            var jhpvm = new JackHobbyProjectViewModel();
            jhpvm.Hobbies = ctx.Hobby.Where(s => s.StudentId == 1).ToList();
            jhpvm.Projects = ctx.Project.Where(s => s.StudentId == 1).ToList();
            return jhpvm;
        }
    }
}
