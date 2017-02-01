using Connection360.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection360.Web.ViewModel
{
    public class HomeViewModel
    {
        public List<Brand> Brands { get; set; }
        public List<Sku> Skus { get; set; }
    }

}