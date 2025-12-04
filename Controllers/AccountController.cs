using Microsoft.AspNetCore.Mvc;

namespace ReceiptTracker.Controllers
{
    public class AccountController :Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}