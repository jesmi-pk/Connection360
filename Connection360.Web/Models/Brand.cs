using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection360.Web.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string Description { get; set; }
        public ICollection<BrandSkuMap> Maps { get; set; }
        
    }
}