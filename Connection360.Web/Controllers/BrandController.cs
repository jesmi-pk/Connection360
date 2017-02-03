using Connection360.Web.Service;
using Connection360.Web.ViewModel;
using PagedList;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Connection360.Web.Controllers
{
    public class BrandController : Controller
    {
        BrandService brandService = new BrandService();
        SkuService skuService = new SkuService();
        HomeViewModel homeViewModel = new HomeViewModel();
        public ActionResult Index(string brandName, string skuName, int? page)
        {
            var result = (from b in brandService.brands
                          join s in skuService.skus on b.Id
                          equals s.Id
                          select new HomeViewModel()
                          {
                              Id = b.Id,
                              Name = b.Name,
                              SkuName = s.Name
                          }).ToList();
            if (!String.IsNullOrWhiteSpace(brandName) && !String.IsNullOrWhiteSpace(skuName)) //You dont require two variables, or two searchbox to search two items.
            {
                result = result.Where(r => r.Name.Contains(brandName) || r.SkuName.Contains(skuName)).ToList();// search is not working properly, only if two search box have the same value, the value pair, it is showing result
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(result.ToPagedList(pageNumber, pageSize));
        }
    }
}