using Connection360.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection360.Web.Service
{
    public class SkuService: DropCreateDatabaseIfModelChanges<BrandModuleContext>
    {
        public List<Sku> skus { get; set; }
        protected override void Seed (BrandModuleContext context)
        {
            skus = new List<Sku>
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
            foreach(var temp in skus)
            { context.Skus.Add(temp);
            }
            context.SaveChanges();
        }
       

    }
}
