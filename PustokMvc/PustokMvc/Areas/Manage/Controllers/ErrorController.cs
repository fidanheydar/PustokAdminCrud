using Microsoft.AspNetCore.Mvc;

namespace PustokMvc.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ErrorController : Controller
    {
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
