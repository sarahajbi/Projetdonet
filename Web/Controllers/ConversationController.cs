using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ConversationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
