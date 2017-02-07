using Connection360.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection360.Web.Service
{
    public class BrandService : DropCreateDatabaseAlways<BrandModuleContext>
    {
        public List<Brand> brands { get; set; }
        protected override void Seed(BrandModuleContext context)
        {
            brands = new List<Brand>
            {
                new Brand {BrandId=1, Name="Malboro",LogoUrl="~/images.jpg", Description="adad sdasd asdas" },
                new Brand {BrandId=2,Name="Nicotex",LogoUrl="~/images.jpg",Description="adad sdasd asdas" },
                new Brand {BrandId=3,Name="Kool",LogoUrl="~/images.jpg", Description="adad sdasd asdas"},
                new Brand {BrandId=4, Name="Malboro",LogoUrl="~/images.jpg", Description="adad sdasd asdas" },
                new Brand {BrandId=5,Name="Nicotex",LogoUrl="~/images.jpg",Description="adad sdasd asdas" },
                new Brand {BrandId=6,Name="Kool",LogoUrl="~/images.jpg", Description="adad sdasd asdas"},
                new Brand {BrandId=7, Name="Malboro",LogoUrl="~/images.jpg", Description="adad sdasd asdas" },
                new Brand {BrandId=8,Name="Nicotex",LogoUrl="~/images.jpg",Description="adad sdasd asdas" },
                new Brand {BrandId=9,Name="Kool",LogoUrl="~/images.jpg", Description="adad sdasd asdas"}
            };
            foreach (var temp in brands)
            {
                context.Brands.Add(temp);
            }
            context.SaveChanges();
        }
        //public List<Brand> GetAll()
        //{
        //    return brands;
        //}

    }
}
