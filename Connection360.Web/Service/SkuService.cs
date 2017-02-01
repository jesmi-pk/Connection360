using Connection360.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection360.Web.Service
{
    public class SkuService
    {
        public List<Sku> skus { get; set; }
        public SkuService()
        {
            var skus = new List<Sku>
            {
                new Sku {Id=1, Name="dsfdsf",ImageUrl="images.jpg"},
                new Sku {Id=2,Name="dfs",ImageUrl="images.jpg" },
                new Sku {Id=3,Name="uiklo",ImageUrl="images.jpg"}

            };


        }
        public List<Sku> GetAll()
        {
            return skus;
        }

    }
}
