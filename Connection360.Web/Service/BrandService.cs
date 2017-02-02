using Connection360.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection360.Web.Service
{
    public class BrandService
    {
        public List<Brand> brands { get; set; }
        public BrandService()
        {
            brands = new List<Brand>
            {
                new Brand {Id=1, Name="Malboro",LogoUrl="images.jpg", Description="adad sdasd asdas" },
                new Brand {Id=2,Name="Nicotex",LogoUrl="images.jpg",Description="adad sdasd asdas" },
                new Brand {Id=3,Name="Kool",LogoUrl="images.jpg", Description="adad sdasd asdas"},
                new Brand {Id=4, Name="Malboro",LogoUrl="images.jpg", Description="adad sdasd asdas" },
                new Brand {Id=5,Name="Nicotex",LogoUrl="images.jpg",Description="adad sdasd asdas" },
                new Brand {Id=6,Name="Kool",LogoUrl="images.jpg", Description="adad sdasd asdas"},
                new Brand {Id=7, Name="Malboro",LogoUrl="images.jpg", Description="adad sdasd asdas" },
                new Brand {Id=8,Name="Nicotex",LogoUrl="images.jpg",Description="adad sdasd asdas" },
                new Brand {Id=9,Name="Kool",LogoUrl="images.jpg", Description="adad sdasd asdas"}
            };
        }
        public List<Brand> GetAll()
        {
            return brands;
        }

    }
}
