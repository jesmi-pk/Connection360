using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Connection360.Web.Models
{
    public class BrandInitializer : DropCreateDatabaseAlways<BrandModuleContext>
    {
        protected override void Seed(BrandModuleContext context)
        {
            var brands = new List<Brand>
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


            var skus = new List<Sku>
            {
                new Sku {SkuId=1, Name="dsfdsf",ImageUrl="~/images.jpg"},
                new Sku {SkuId=2,Name="dfs",ImageUrl="~/images.jpg" },
                new Sku {SkuId=3,Name="uiklo",ImageUrl="~/images.jpg"},
                new Sku {SkuId=4, Name="dsfdsf",ImageUrl="~/images.jpg"},
                new Sku {SkuId=5,Name="dfs",ImageUrl="~/images.jpg" },
                new Sku {SkuId=6,Name="uiklo",ImageUrl="~/images.jpg"},
                new Sku {SkuId=7, Name="dsfdsf",ImageUrl="~/images.jpg"},
                new Sku {SkuId=8,Name="dfs",ImageUrl="~/images.jpg" },
                new Sku {SkuId=9,Name="uiklo",ImageUrl="~/images.jpg"}

            };
            foreach (var temp in skus)
            {
                context.Skus.Add(temp);
            }
            context.SaveChanges();

            var brandSkuMap = new List<BrandSkuMap>
            {
                new BrandSkuMap {BrandSkuMapId=1,BrandId=1,SkuId=1 },
                new BrandSkuMap {BrandSkuMapId=2,BrandId=1,SkuId=2 },
                new BrandSkuMap {BrandSkuMapId=3,BrandId=1,SkuId=3 },
                new BrandSkuMap {BrandSkuMapId=4,BrandId=2,SkuId=4 },
                new BrandSkuMap {BrandSkuMapId=5,BrandId=2,SkuId=5 },
                new BrandSkuMap {BrandSkuMapId=6,BrandId=3,SkuId=6 },
                new BrandSkuMap {BrandSkuMapId=7,BrandId=3,SkuId=7 },
            };
            foreach (var temp in brandSkuMap)
            {
                context.BrandSkuMaps.Add(temp);
            }
            context.SaveChanges();
        }
    }
}