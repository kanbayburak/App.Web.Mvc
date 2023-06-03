using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminBlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
