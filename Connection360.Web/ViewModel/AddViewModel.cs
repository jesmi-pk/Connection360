using Connection360.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection360.Web.ViewModel
{
    public class AddViewModel
    {
        public int Id { get; set; }
        public Brand brand { get; set; }
        public string Name { get; set; }
        public string BrandLogo { get; set; }
        public string BrandDescription { get; set; }
        public string SkuName { get; set; }
        public string SkuUrl { get; set; }

        public Sku sku { get; set; }
        public List<Sku> skus { get; set; }
    }
}