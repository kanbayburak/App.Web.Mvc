using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminSettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
