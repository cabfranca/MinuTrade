using System.Web.Mvc;

namespace SGC.UI.WEB.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}
