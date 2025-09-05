using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           // var r = new ContentResult();
           ///r.Content = "hello";
          //  r.StatusCode=(int)HttpStatusCode.OK;
          //  r.ContentType = "text/html";
            return View();
        }
        [HttpGet]

        public IActionResult Privacy()
        {
            // var r = new ContentResult();
            ///r.Content = "hello";
            //  r.StatusCode=(int)HttpStatusCode.OK;
            //  r.ContentType = "text/html";
            return View();
        }
        [HttpGet]
        public IActionResult ContactUs()
        {



            return View();
        }
        [HttpGet]
        public IActionResult AboutUs()
        {



            return View();
        }
        // public IActionResult con()
        // {

        //    return Content("");
        //   }
        // public RedirectResult update()
        // {



        //  var r = new RedirectResult("https://www.google.com");
        // return r;

        // }
        public IActionResult update()
        {



            var r = new RedirectToActionResult(nameof(ProductsController.Get),"Products",new
            {
                id=10
            });
            return r;

        }
    }
}
