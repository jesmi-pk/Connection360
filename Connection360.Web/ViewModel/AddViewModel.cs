using Connection360.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Connection360.Web.ViewModel
{
    public class AddViewModel
    {
        public int Id { get; set; }

        public Brand brand { get; set; }

       
        public Sku sku { get; set; }
        //public List<Sku> skus { get; set; }
    }
}