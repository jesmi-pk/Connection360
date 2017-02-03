using Connection360.Web.Models;
using Connection360.Web.Service;
using Connection360.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Connection360.Web.Controllers
{
    public class BrandController : Controller
    {
        BrandService brandService = new BrandService();
        SkuService skuService = new SkuService();
        HomeViewModel homeViewModel = new HomeViewModel();    
        public ActionResult Index(string brandName, string skuName,int? page)
        {
            var result = (from b in brandService.brands
                          join s in skuService.skus on b.Id
                          equals s.Id select new HomeViewModel()
                          {
                              Id = b.Id,
                              Name = b.Name,
                              SkuName = s.Name
                          }).ToList();
            if (!String.IsNullOrWhiteSpace(brandName) && !String.IsNullOrWhiteSpace(skuName))
            {               
               result = result.Where(r => r.Name.Contains(brandName) || r.SkuName.Contains(skuName)).ToList();               
            }
            else if(!String.IsNullOrWhiteSpace(brandName))
            {
                result = result.Where(r => r.Name.Contains(brandName)).ToList();
            }
            else if(!String.IsNullOrWhiteSpace(skuName))
            {
                result = result.Where(r => r.SkuName.Contains(skuName)).ToList();
            }
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(result.ToPagedList(pageNumber,pageSize));
        }
        public ActionResult Add()
        {
            return View();

        }
    }
}