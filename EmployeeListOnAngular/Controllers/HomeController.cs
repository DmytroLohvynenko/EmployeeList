using System.Web.Mvc;

namespace EmployeeListOnAngular.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}