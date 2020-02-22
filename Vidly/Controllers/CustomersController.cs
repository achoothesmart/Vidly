using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var model = new RandomMovieViewModel
            {
                Movie = new Models.Movie { Name = "Test" },
                Customers = new List<Models.Customer>()
                {
                    //new Models.Customer { Name = "Peter" },
                    //new Models.Customer { Name = "Ben" },
                    //new Models.Customer { Name = "Mike" }
                }
            };
            return View(model);
        }
    }
}