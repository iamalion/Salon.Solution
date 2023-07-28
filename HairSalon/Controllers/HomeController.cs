using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.Page = "Eau Clair's Salon";
        return View();
      }

    }
}