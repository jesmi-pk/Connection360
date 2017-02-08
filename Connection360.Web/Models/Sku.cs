using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection360.Web.Models
{
    public class Sku
    {
        public int SkuId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public List<BrandSkuMap> BrandSkuMaps { get; set; }

    }
}