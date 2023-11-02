using john_moreau_C6_FAQs_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
/*
* John Moreau
* CSS233
* 11/1/2023
*
*
*/
namespace john_moreau_C6_FAQs_app.Controllers
{
    public class HomeController : Controller
    {

        private FAQContext Context { get; set; }

        public HomeController(FAQContext ctx) => Context = ctx;

        public IActionResult Index(string topic, string category)
        {

            var faqs = Context.FAQs.Include(f => f.Category).Include(f => f.Topic);
            
            if (!string.IsNullOrEmpty(topic) && !string.IsNullOrEmpty(category))
            {
                ViewData["Topic"] = topic;
                ViewData["Category"] = topic;
                return View(faqs.Where(f => f.TopicId == topic && f.CategoryId == category).ToList());
            }
            else if (!string.IsNullOrEmpty(topic))
            {
                ViewData["Topic"] = topic;
                return View(faqs.Where(f => f.TopicId == topic).ToList());
            }
            else if (!string.IsNullOrEmpty(category))
            {
                ViewData["Category"] = topic;
                return View(faqs.Where(f => f.CategoryId == category).ToList());
            }

            return View(faqs.ToList());
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