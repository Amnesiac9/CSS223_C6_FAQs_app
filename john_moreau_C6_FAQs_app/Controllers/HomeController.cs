using john_moreau_C6_FAQs_app.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace john_moreau_C6_FAQs_app.Controllers
{
    public class HomeController : Controller
    {

        private FAQContext Context { get; set; }

        public HomeController(FAQContext ctx) => Context = ctx;


        public IActionResult Index()
        {
            return View(Context.FAQs.ToList());
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
    }
}