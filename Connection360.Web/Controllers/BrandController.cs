using Connection360.Web.Models;
using Connection360.Web.Service;
using Connection360.Web.ViewModel;
using PagedList;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Connection360.Web.Controllers
{
    public class BrandController : Controller
    {       
        private BrandModuleContext db = new BrandModuleContext();       
        Brand_SkuViewModel Brand_SkuViewModel = new Brand_SkuViewModel();
        public ActionResult Index(string brandName, string skuName, int? page)
        {
            var brands = db.Brands.ToList();
            var skus = db.Skus.ToList();
            var result = (from b in db.Brands
                          join s in db.Skus on b.BrandId
                          equals s.SkuId
                          select new Brand_SkuViewModel()
                          {                             
                              Id = b.BrandId,
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
            return View(result.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Brand brand,HttpPostedFileBase file)      
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.ContentLength>0)
                {
                    string ImageName = System.IO.Path.GetFileName(file.FileName);
                    string physicalPath = Server.MapPath("~/images/" + ImageName);
                    file.SaveAs(physicalPath);
                    brand.LogoUrl = ImageName;
                }                 
                brand.Name = Request.Form["Name"];
                brand.Description = Request.Form["Description"];
                db.Brands.Add(brand);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brand);



        }
       
    }
}