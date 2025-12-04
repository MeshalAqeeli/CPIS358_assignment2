using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReceiptTracker.Models;

namespace ReceiptTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {

                SetCookies("userName", User.Identity.Name);
            }
            else
            {

                SetCookies("userName", "guest");
            }
            SetCookies("broswerName", Request.Headers["User-Agent"].ToString());
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SetCookies(string cookieName, string cookieValue)
        {
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(15), 
                HttpOnly = true, 
                
            Secure = true, 
                SameSite = SameSiteMode.Strict 
            };
            Response.Cookies.Append(cookieName, cookieValue, options);
            return Ok("Cookies has been set.");
        }
    }
}
