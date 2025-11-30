using Business.Services;
using Core.Abstracts.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController()
        {
            productService = new ProductService();
        }
        // GET: Home
        public ActionResult Index()
        {
            var model = new Models.HomeIndexViewModel
            {
                FeaturedProducts = productService.GetFeaturedProducts(3),
                NewArrivals = productService.GetNewArrivals(3),
                NewCategories = productService.GetAllCategories().Take(3)
            };
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}