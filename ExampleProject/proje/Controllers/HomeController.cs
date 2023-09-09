using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using proje.Models;

namespace proje.Controllers
{
	public class HomeController : Controller
	{
        
        [HttpGet]
		public IActionResult Index()
		{
			
			return View();
		}

        [HttpPost]
        public IActionResult Index(Kisi k)
        {
            Context context = new Context();
			context.kisiler.Add(k);
			context.SaveChanges();


            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }



    }
}
