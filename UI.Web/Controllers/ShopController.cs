using Business.Services;
using Core.Abstracts.IServices;
using Core.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService productService;

        public ShopController()
        {
            productService = new ProductService();
        }
        // GET: Shop
        public ActionResult Index(ProductFilterDTO filter = null)
        {
            var model = new Models.ShopIndexViewModel
            {
                Categories = productService.GetAllCategories(),
                OriginCountries = productService.GetAllOriginCountries(),
                SearchResult = productService.GetProducts(filter)
            };
            return View(model);
        }

        public ActionResult ProductDetails(int id)
        {
            return View();
        }
    }
}