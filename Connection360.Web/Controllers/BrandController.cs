using Connection360.Web.Models;
using Connection360.Web.Service;
using Connection360.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Connection360.Web.Controllers
{
    public class BrandController : Controller
    {
        BrandService brandService = new BrandService();
        SkuService skuService = new SkuService();
        HomeViewModel homeViewModel = new HomeViewModel();
        public ActionResult Index()
        {
            homeViewModel.Brands =brandService.GetAll() ;
            homeViewModel.Skus =skuService.GetAll() ;
            
            return View(homeViewModel);
        }
    }
}