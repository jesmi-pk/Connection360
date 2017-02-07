using Connection360.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection360.Web.ViewModel
{
    public class Brand_SkuViewModel
    {
       public Brand brand { get; set; }
       
        public List<Sku> skus { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SkuName { get; set; }

        
       

    }

}