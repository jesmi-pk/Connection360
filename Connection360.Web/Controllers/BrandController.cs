using Connection360.Web.Models;
using Connection360.Web.Service;
using Connection360.Web.ViewModel;
using PagedList;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Drawing;
using System.Drawing.Imaging;

namespace Connection360.Web.Controllers
{
    public class BrandController : Controller
    {
        Brand brand = new Brand();
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
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
       
        public ActionResult Create(AddViewModel addViewModel,HttpPostedFileBase file)      
       
        {
            int maxContent = 1024 * 1024; //1 MB
            string[] sAllowedExt = new string[] { ".jpg", ".gif", ".png" };


           

          
            
                

           
                if (file == null)
                    ModelState.AddModelError("", "Please upload a file");
                else if (!sAllowedExt.Contains(file.FileName.Substring(file.FileName.LastIndexOf('.'))))
                {
                    string ErrorMessage = "Please upload Your Photo of type: " + string.Join(", ", sAllowedExt);
                    ModelState.AddModelError("", ErrorMessage);

                }
                else if (file.ContentLength > maxContent)
                {
                    string ErrorMessage = "Your Photo is too large, maximum allowed size is : " + (maxContent / 1024).ToString() + "MB";
                    ModelState.AddModelError("", ErrorMessage);
                }
                else if (file != null && file.ContentLength > 0)
                {
                    string ImageName = System.IO.Path.GetFileName(file.FileName);
                    string physicalPath = Server.MapPath("~/images/" + ImageName);
                    file.SaveAs(physicalPath);
                    brand.LogoUrl = ImageName;
                }

            if (ModelState.IsValid)
            {
                brand.Name = addViewModel.brand.Name;
                brand.Description = addViewModel.brand.Description;
                db.Brands.Add(brand);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();



        }
       
    }
}