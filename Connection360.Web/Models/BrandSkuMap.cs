using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection360.Web.Models
{
    public class BrandSkuMap
    {
        public int BrandSkuMapId { get; set; }
        public int BrandId { get; set; }
        public int SkuId { get; set; }
        public Brand brand { get; set; }
        public Sku sku { get; set; }
    }
}